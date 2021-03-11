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
using DBioPhoto.DataAccess.Services.Adding;

namespace DBioPhoto.Frontend
{
    public partial class AddingForm : Form
    {
        // Information about folder and thumbnails
        private string _folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private string[] _imagePaths;
        private ImageList _imageList;
        private Image[] _imageThumbnails;

        // Information about currently selected photo
        private Image _showedImage;
        private string _showedImagePath;
        private DateTime _showedImageDate;
        private int _selectedIndex;

        // Backgroundworkers
        private BackgroundWorker LoadingImagesBgWorker;
        private BackgroundWorker AddingPhotosBgWorker;
        private BackgroundWorker PhotoInfoSuggestionsBgWorker;

        // Collections for autocomplete
        private AutoCompleteStringCollection _photoInfoSuggestions;

        // Regex for getting DateTime from EXIF of an image
        private static Regex _regex = new Regex(":");

        public AddingForm()
        {
            InitializeComponent();
            this.Location = new System.Drawing.Point(0, 0);

            // Populate the combo box with data from enum
            categoryComboBox.DataSource = Enum.GetValues(typeof(Category));

            // Create the BackgroundWorker for loading of images, bind tasks for him
            LoadingImagesBgWorker = new BackgroundWorker();
            LoadingImagesBgWorker.DoWork += new DoWorkEventHandler(LoadingImagesBgWorker_DoWork);
            LoadingImagesBgWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(LoadingImagesBgWorker_RunWorkerEventCompleted);

            // Create the BackgroundWorker for adding photos, bind tasks for him
            AddingPhotosBgWorker = new BackgroundWorker();
            AddingPhotosBgWorker.DoWork += new DoWorkEventHandler(AddingPhotosBgWorker_DoWork);
            AddingPhotosBgWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(AddingPhotosBgWorker_RunWorkerEventCompleted);

            // Create the BackgroundWorker for photo info suggestions, bind tasks for him
            PhotoInfoSuggestionsBgWorker = new BackgroundWorker();
            PhotoInfoSuggestionsBgWorker.DoWork += new DoWorkEventHandler(PhotoInfoSuggestionsBgWorker_DoWork);
            PhotoInfoSuggestionsBgWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(PhotoInfoSuggestionsBgWorker_RunWorkerEventCompleted);

            // Set location and comment textboxes to autocomplete
            _photoInfoSuggestions = new AutoCompleteStringCollection();
            locationTextBox.AutoCompleteCustomSource = _photoInfoSuggestions;
            commentTextBox.AutoCompleteCustomSource = _photoInfoSuggestions;
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
            Global.DbContext.SaveChanges();
        }

        private void organismAddButton_Click(object sender, System.EventArgs e)
        {
            // If already opened, bring to front, else create new
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
                folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyDocuments;
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
            // Clear the images now loaded
            imagesListView.Items.Clear();
            // Load images in the background
            LoadingImagesBgWorker.RunWorkerAsync();
        }

        private void imagesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // When selecting an image, show it and save the index, get the datetime of creation
            if (imagesListView.SelectedIndices.Count > 0)
            {
                _selectedIndex = imagesListView.SelectedIndices[0];
                _showedImagePath = _imagePaths[_selectedIndex];
                _showedImage = Image.FromFile(_showedImagePath);
                _showedImageDate = GetDateTakenFromImage(_showedImage);

                selectedImagePictureBox.Image = _showedImage;
                showedPhotoPathTextBox.Text = _showedImagePath;
                showedPhotoDateTextBox.Text = _showedImageDate.ToString();
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
            string filePath = _showedImagePath;
            Category category = (Category)categoryComboBox.SelectedItem;
            string comment = commentTextBox.Text.Trim().ToLower();
            string location = locationTextBox.Text.Trim().ToLower();

            Photo tryPhoto = new Photo(date, fileName, filePath, category, comment, location);

            // Add to db in background
            addPhotoToDbButton.Text = "Přidávám!";
            AddingPhotosBgWorker.RunWorkerAsync(tryPhoto);

            // Not resetting this form, because it can be useful to use the location again
        }
        private void AddingPhotosBgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Add the created instance to the database
            e.Result = AddPhoto.TryAddPhoto(Global.DbContext, (Photo)e.Argument);
        }
        private void AddingPhotosBgWorker_RunWorkerEventCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Check if the photo was added successfully, show result, if not successfull, refill the form
            if (e.Error != null)
                MessageBox.Show(e.Error.Message);
            else if (e.Cancelled)
                ShowOnPhotoToDbButtonForThreeSecs("Operace zrušena");
            else
            {
                string result = (string)e.Result;
                ShowOnPhotoToDbButtonForThreeSecs(result);
            }
        }
        private void ShowOnPhotoToDbButtonForThreeSecs(string textToShow)
        {
            // Show textToShow on the button, after 3 s show original again
            addPhotoToDbButton.Text = textToShow;
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer()
            {
                Interval = 3000,
                Enabled = true
            };
            timer.Tick += (sender, e) =>
            {
                addPhotoToDbButton.Text = "Přidat fotku do databáze";
                timer.Dispose();
            };
        }

        private void locationTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t != null)
            {
                if (t.Text.Length == 3)
                {
                    PhotoInfoSuggestionsBgWorker.RunWorkerAsync((t.Text, 0));
                }
            }
        }

        private void commentTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t != null)
            {
                if (t.Text.Length == 3)
                {
                    PhotoInfoSuggestionsBgWorker.RunWorkerAsync((t.Text, 1));
                }
            }
        }
        private void PhotoInfoSuggestionsBgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Find the suggestions in the background
            (string beginning, int textBoxNumber) = (ValueTuple<string, int>)e.Argument;
            e.Result = Suggestions.GetPhotoInfoSuggestions(Global.DbContext, beginning, textBoxNumber);
        }
        private void PhotoInfoSuggestionsBgWorker_RunWorkerEventCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // After finding the suggestions, use them
            if (e.Error != null)
                MessageBox.Show(e.Error.Message);
            else if (e.Cancelled)
                MessageBox.Show("Operace zrušena");
            else
            {
                _photoInfoSuggestions.Clear();
                _photoInfoSuggestions.AddRange((string[])e.Result);
            }
        }
    }
}
