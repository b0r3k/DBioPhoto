using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Drawing.Imaging;
using System.Text;
using System.Text.RegularExpressions;
using DBioPhoto.Domain.Models;
using DBioPhoto.DataAccess.Data;
using DBioPhoto.DataAccess.Services.Adding;
using System.Threading.Tasks;

namespace DBioPhoto.Frontend
{
    public partial class AddingForm : Form
    {
        // Information about folder and thumbnails
        private string _folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
        private string[] _imagePaths;
        private ImageList _imageList;
        private Image[] _imageThumbnails;

        // Information about currently selected photo
        private Image _showedImage;
        private string _showedImagePath;
        private string _showedImageRelativePath;
        private DateTime _showedImageDate;
        private int _selectedIndex;

        // DbContexts
        private DBioPhotoContext _photoAddingContext;
        private DBioPhotoContext _photoInfoSuggestionsContext;

        // Backgroundworkers
        private BackgroundWorker LoadingImagesBgWorker;
        private BackgroundWorker AddingPhotosBgWorker;
        private BackgroundWorker PhotoInfoSuggestionsBgWorker;
        private BackgroundWorker OnPhotoGettingBgWorker;
        private BackgroundWorker PhotoContentSuggestionsBgWorker;
        private BackgroundWorker AddingContentToPhotoBgWorker;

        // Collections for autocomplete
        private AutoCompleteStringCollection _photoInfoSuggestions;
        private AutoCompleteStringCollection _photoContentSuggestions;

        // Regex for getting DateTime from EXIF of an image
        private static Regex _regex = new Regex(":");

        public AddingForm()
        {
            InitializeComponent();
            this.Location = new System.Drawing.Point(0, 0);

            // Populate the combo box with data from enum
            categoryComboBox.DataSource = Enum.GetValues(typeof(Category));

            // Create the DbContexts
            _photoAddingContext = new DBioPhotoContext(Global.DbFilePath);
            _photoInfoSuggestionsContext = new DBioPhotoContext(Global.DbFilePath);

            // Create the BackgroundWorker for loading of images, bind tasks for him
            LoadingImagesBgWorker = new BackgroundWorker();
            LoadingImagesBgWorker.DoWork += new DoWorkEventHandler(LoadingImagesBgWorker_DoWork);
            LoadingImagesBgWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(LoadingImagesBgWorker_RunWorkerEventCompleted);

            // Create the BackgroundWorker for getting lists of stuff on the photo, bind tasks for him
            OnPhotoGettingBgWorker = new BackgroundWorker();
            OnPhotoGettingBgWorker.DoWork += new DoWorkEventHandler(OnPhotoGettingBgWorker_DoWork);
            OnPhotoGettingBgWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(OnPhotoGettingBgWorker_RunWorkerEventCompleted);

            // Create the BackgroundWorker for getting suggestion of organisms and people, bind tasks for him
            PhotoContentSuggestionsBgWorker = new BackgroundWorker();
            PhotoContentSuggestionsBgWorker.DoWork += new DoWorkEventHandler(PhotoContentSuggestionsBgWorker_DoWork);
            PhotoContentSuggestionsBgWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(PhotoContentSuggestionsBgWorker_RunWorkerEventCompleted);

            // Set location and comment textboxes to autocomplete
            _photoInfoSuggestions = new AutoCompleteStringCollection();
            locationTextBox.AutoCompleteCustomSource = _photoInfoSuggestions;
            commentTextBox.AutoCompleteCustomSource = _photoInfoSuggestions;

            // Set photo content textboxes to autocomplete
            _photoContentSuggestions = new AutoCompleteStringCollection();
            organismNameTextBox.AutoCompleteCustomSource = _photoContentSuggestions;
            personNameOrNickTextBox.AutoCompleteCustomSource = _photoContentSuggestions;

            // Create the BackgroundWorker for adding content to photos, bind tasks for him
            AddingContentToPhotoBgWorker = new BackgroundWorker();
            AddingContentToPhotoBgWorker.DoWork += new DoWorkEventHandler(AddingContentToPhotoBgWorker_DoWork);
            AddingContentToPhotoBgWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(AddingContentToPhotoBgWorker_RunWorkerEventCompleted);
        }

        private void LoadingImagesBgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Get all the images from selected directory, reset the thumbnails
            _imagePaths = Directory.EnumerateFiles(_folderPath, "*.jpg*", SearchOption.TopDirectoryOnly)
                .Where(f => f.ToLower().EndsWith(".jpg") || f.ToLower().EndsWith(".jpeg") || f.ToLower().EndsWith(".png")).ToArray();
            _imageThumbnails = new Image[_imagePaths.Length];
            _imageList = new ImageList();

            // If there are any images, get thumbnails for them
            if (_imagePaths.Length > 0)
                GetThumbnailsForImages(_imagePaths);
        }
        private void GetThumbnailsForImages(string[] imageFiles)
        {
            // Get the thumbnails from paths
            for (int i = 0; i < imageFiles.Length; i++)
            {
                _imageThumbnails[i] = Image.FromFile(imageFiles[i]).GetThumbnailImage(120, 90, new Image.GetThumbnailImageAbort(() => false), IntPtr.Zero);
            }

            // Assign the thumbnails to the imageList
            _imageList = new ImageList();
            _imageList.ImageSize = new Size(120, 90);
            _imageList.Images.AddRange(_imageThumbnails);
        }

        private void LoadingImagesBgWorker_RunWorkerEventCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // View the imageList in imagesListView
            imagesListView.LargeImageList = _imageList;
            if (_imageThumbnails != null && _imagePaths != null && _imageThumbnails.Length == _imagePaths.Length)
            {
                for (int itemIndex = 0; itemIndex < _imageThumbnails.Length; itemIndex++)
                {
                    imagesListView.Items.Add(new ListViewItem(Path.GetFileName(_imagePaths[itemIndex]), itemIndex));
                }
            }
        }

        private void AddingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AddingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void organismAddButton_Click(object sender, System.EventArgs e)
        {
            // If OrganismAddForm already opened, bring to front, else create new
            if (Application.OpenForms.OfType<OrganismAddForm>().Count() == 1)
            {
                OrganismAddForm openedForm = Application.OpenForms.OfType<OrganismAddForm>().First();
                openedForm.WindowState = FormWindowState.Normal;
                openedForm.BringToFront();
            }
            else
            {
                OrganismAddForm newGui = new OrganismAddForm();
                newGui.StartPosition = FormStartPosition.Manual;
                newGui.Location = new Point(1536, 0);
                newGui.Visible = true;
            }
        }

        private void folderPathTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            // Let user choose the folder, save the path
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyPictures;
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of selected folder
                    _folderPath = folderBrowserDialog.SelectedPath;
                    folderPathTextBox.Text = _folderPath;
                }
            }
        }

        private void folderChooseButton_Click(object sender, EventArgs e)
        {
            if (_folderPath.Contains(Global.RootFolder))
            {
                // Clear the images now loaded
                imagesListView.Items.Clear();
                selectedImagePictureBox.Image = null;
                
                // Reset showedImage values
                _showedImage.Dispose();
                _showedImage = null;
                _showedImagePath = null;
                _showedImageRelativePath = null;
                
                // Load images in the background
                 LoadingImagesBgWorker.RunWorkerAsync();
            }
            else
                MessageBox.Show("Tato složka není ve zvoleném kořenovém adresáři, databáze by nefungovala správně! Zvolte jinou.");
        }

        private void imagesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (imagesListView.SelectedIndices.Count > 0)
            {
                // When selecting an image, save the index, path, get the datetime of creation
                _selectedIndex = imagesListView.SelectedIndices[0];
                _showedImagePath = _imagePaths[_selectedIndex];
                _showedImageRelativePath = _showedImagePath.Replace(Global.RootFolder, "");

                if (_showedImage != null)
                    _showedImage.Dispose();

                _showedImage = Image.FromFile(_showedImagePath);
                _showedImageDate = GetDateTakenFromImage(_showedImage);

                // View the image, view info in textboxes
                selectedImagePictureBox.Image = _showedImage;
                showedPhotoPathTextBox.Text = _showedImagePath;
                showedPhotoRelativePathTextBox.Text = _showedImageRelativePath;
                showedPhotoDateTextBox.Text = _showedImageDate.ToString();

                // Get what's on the photo in the background, populate the ListBoxes with it
                OnPhotoGettingBgWorker.RunWorkerAsync();
            }
        }

        private DateTime GetDateTakenFromImage(Image image)
        {
            // Try to get the datetime of creation property from image and parse it
            PropertyItem propItem = null;
            try
            {
                propItem = image.GetPropertyItem(36867);
            }
            catch { }
            if (propItem != null)
            {
                string dateTaken = _regex.Replace(Encoding.UTF8.GetString(propItem.Value), "-", 2);
                return DateTime.Parse(dateTaken);
            }
            else
                return new FileInfo(_showedImagePath).LastWriteTime;
        }


        private void addPhotoToDbButton_Click(object sender, EventArgs e)
        {
            // Get the values from the form, lowecase everything, create the instance of Organism
            DateTime date = _showedImageDate;
            string fileName = Path.GetFileName(_showedImagePath);
            string filePath = _showedImageRelativePath;
            Category category = (Category)categoryComboBox.SelectedItem;
            string comment = commentTextBox.Text.Trim().ToLower();
            string location = locationTextBox.Text.Trim().ToLower();

            Photo tryPhoto = new Photo(date, fileName, filePath, category, comment, location);

            // Add to ThreadPool task to TryAddPhoto
            Task.Run(() => TryAddPhotoLocking(tryPhoto));

            // Not resetting this form, because it can be useful to use the location again
        }
        private void TryAddPhotoLocking(Photo tryPhoto)
        {
            string result;
            // Lock the DbContext until finished
            lock (_photoAddingContext)
            {
                result = AddPhoto.TryAddPhoto(_photoAddingContext, tryPhoto);
            }
            // Invoke showing result on the main thread, if unsuccessfull, invoke also showing the person
            Invoke(new Action( () => Global.ShowOnButtonForThreeSecs(result, addPhotoToDbButton) ));
        }


        // When there are 3 chars in textbox and keyup, get autocomplete suggestions for that box in other thread
        private void locationTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t != null && t.Text.Length == 3)
            {
                Task.Run(() => GetPhotoInfoSuggestionsLocking(t.Text, 0));
            }
        }
        private void commentTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t != null && t.Text.Length == 3)
            {
                Task.Run( () => GetPhotoInfoSuggestionsLocking(t.Text, 1) );
            }
        }
        // Get suggestions from db, lock context for it
        private void GetPhotoInfoSuggestionsLocking(string beginning, int textBoxNumber)
        {
            string[] result;
            // Lock the DbContext until finished
            lock (_photoInfoSuggestionsContext)
            {
                result = Suggestions.GetPhotoInfoSuggestions(_photoInfoSuggestionsContext, beginning, textBoxNumber);
            }
            // Invoke using results for autocomplete on the main thread
            Invoke(new Action(() => { _photoInfoSuggestions.Clear(); _photoInfoSuggestions.AddRange(result); }));
        }

        private void OnPhotoGettingBgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Find in db what's on the photo in the background
            var usedContext = new DataAccess.Data.DBioPhotoContext(Global.DbFilePath);
            e.Result = (AddPhoto.QueryOrganismsOnPhoto(usedContext, _showedImageRelativePath), AddPhoto.QueryPeopleOnPhoto(usedContext, _showedImageRelativePath));
            usedContext.SaveChanges();
            usedContext.Dispose();
        }
        private void OnPhotoGettingBgWorker_RunWorkerEventCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // After finding the organisms and people, show it in the listboxes
            if (e.Error != null)
                MessageBox.Show(e.Error.Message);
            else if (e.Cancelled)
                MessageBox.Show("Operace zrušena");
            else
            {
                (List<Organism> organismsOnPhoto, List<Person> peopleOnPhoto) = (ValueTuple<List<Organism>, List<Person>>)e.Result;
                organismsOnPhotoListBox.DataSource = organismsOnPhoto;
                peopleOnPhotoListBox.DataSource = peopleOnPhoto;
            }
        }

        private void removeOrganismFromPhotoButton_Click(object sender, EventArgs e)
        {
            // Remove organism from photo, update the listbox
            if (organismsOnPhotoListBox.SelectedIndices.Count == 1)
            {
                var usedContext = new DataAccess.Data.DBioPhotoContext(Global.DbFilePath);
                AddPhoto.RemoveOrganismFromPhoto(usedContext, _showedImageRelativePath, organismsOnPhotoListBox.SelectedIndex);
                usedContext.SaveChanges();
                usedContext.Dispose();
                OnPhotoGettingBgWorker.RunWorkerAsync();
            }
        }

        private void removePersonFromPhotoButton_Click(object sender, EventArgs e)
        {
            // Remove person from photo, update the listbox
            if (peopleOnPhotoListBox.SelectedIndices.Count == 1)
            {
                var usedContext = new DataAccess.Data.DBioPhotoContext(Global.DbFilePath);
                AddPhoto.RemovePersonFromPhoto(usedContext, _showedImageRelativePath, peopleOnPhotoListBox.SelectedIndex);
                usedContext.SaveChanges();
                usedContext.Dispose();
                OnPhotoGettingBgWorker.RunWorkerAsync();
            }
        }

        private void organismNameTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t != null && t.Text.Length == 3 && !PhotoContentSuggestionsBgWorker.IsBusy)
            {
                PhotoContentSuggestionsBgWorker.RunWorkerAsync((t.Text, 0));
            }
        }
        private void personNameOrNickTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t != null && t.Text.Length == 3 && !PhotoContentSuggestionsBgWorker.IsBusy)
            {
                PhotoContentSuggestionsBgWorker.RunWorkerAsync((t.Text, 1));
            }
        }
        private void PhotoContentSuggestionsBgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Find the suggestions in the background
            var usedContext = new DataAccess.Data.DBioPhotoContext(Global.DbFilePath);
            (string beginning, int textBoxNumber) = (ValueTuple<string, int>)e.Argument;
            e.Result = Suggestions.GetPhotoContentSuggestions(usedContext, beginning, textBoxNumber);
            usedContext.SaveChanges();
            usedContext.Dispose();
        }
        private void PhotoContentSuggestionsBgWorker_RunWorkerEventCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // After finding the suggestions, use them
            if (e.Error != null)
                MessageBox.Show(e.Error.Message);
            else if (e.Cancelled)
                MessageBox.Show("Operace zrušena");
            else
            {
                _photoContentSuggestions.Clear();
                _photoContentSuggestions.AddRange((string[])e.Result);
            }
        }


        private void addOrganismToPhotoButton_Click(object sender, EventArgs e)
        {
            string tryOrganismInfo = organismNameTextBox.Text;
            string[] tryOrganismNames = tryOrganismInfo.Split(' ');
            if (tryOrganismNames.Length >= 2 && _showedImageRelativePath != null)
            {
                AddingContentToPhotoBgWorker.RunWorkerAsync((tryOrganismNames, true));
            }
            OnPhotoGettingBgWorker.RunWorkerAsync();
        }

        private void addPersonToPhotoButton_Click(object sender, EventArgs e)
        {
            string tryPersonInfo = personNameOrNickTextBox.Text;
            string[] tryPersonNames = tryPersonInfo.Split(' ');
            if (tryPersonNames.Length >= 3 && _showedImageRelativePath != null)
            {
                AddingContentToPhotoBgWorker.RunWorkerAsync((tryPersonNames, false));
            }
        }

        private void AddingContentToPhotoBgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Try to add the content to photo in the background
            (string[] names, bool addingOrganism) = (ValueTuple<string[], bool>)e.Argument;
            var usedContext = new DataAccess.Data.DBioPhotoContext(Global.DbFilePath);
            if (addingOrganism)
                e.Result = (AddPhoto.TryAddOrganismToPhoto(usedContext, _showedImageRelativePath, names[0], names[1]), true);
            else
                e.Result = (AddPhoto.TryAddPersonToPhoto(usedContext, _showedImageRelativePath, names[0], names[2]), false);
            usedContext.SaveChanges();
            usedContext.Dispose();
        }
        private void AddingContentToPhotoBgWorker_RunWorkerEventCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Show the result
            if (e.Error != null)
                MessageBox.Show(e.Error.Message);
            else if (e.Cancelled)
                MessageBox.Show("Operace zrušena");
            else
            {
                (bool successfull, bool addingOrganism) = (ValueTuple<bool, bool>)e.Result;
                if (successfull)
                {
                    if (addingOrganism)
                        Global.ShowOnButtonForThreeSecs("Úspěšně přidáno!", addOrganismToPhotoButton);
                    else
                        Global.ShowOnButtonForThreeSecs("Úspěšně přidáno!", addPersonToPhotoButton);

                    OnPhotoGettingBgWorker.RunWorkerAsync();
                }
                else
                {
                    if (addingOrganism)
                        Global.ShowOnButtonForThreeSecs("Nešlo přidat.", addOrganismToPhotoButton);
                    else
                        Global.ShowOnButtonForThreeSecs("Nešlo přidat.", addPersonToPhotoButton);
                }
            }
        }


        private void personAddButton_Click(object sender, EventArgs e)
        {
        }
    }
}
