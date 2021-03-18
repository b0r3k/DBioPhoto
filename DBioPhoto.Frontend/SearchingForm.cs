using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBioPhoto.DataAccess.Data;
using DBioPhoto.DataAccess.Services.Filtering;
using DBioPhoto.Domain.Models;

namespace DBioPhoto.Frontend
{
    public partial class SearchingForm : Form
    {
        private DBioPhotoContext _searchingContext;
        private DBioPhotoContext _suggestionsContext;

        // Information about folder and thumbnails
        private string[] _imageRelativePaths;
        private ImageList _imageList;
        private Image[] _imageThumbnails;

        // Information about currently selected photo
        private Image _showedImage;
        private string _showedImagePath;
        private string _showedImageRelativePath;
        private DateTime _showedImageDate;
        private int _selectedIndex;

        // Backgroundworker for loading images
        private BackgroundWorker LoadingImagesBgWorker;

        // Collection for autocomplete
        private AutoCompleteStringCollection _suggestions;

        public SearchingForm()
        {
            InitializeComponent();

            untilDateTimePicker.Value = DateTime.Now;

            // Populate the basedOnComboBox
            basedOnComboBox.DataSource = new string[] { "Nic dalšího", "Český název organimu", "Latinský název organismu",  "Jméno osoby" };

            // Populate the combo box with data from enum
            categoryComboBox.DataSource = Enum.GetValues(typeof(Category));

            // Create the DbContexts
            _searchingContext = new DBioPhotoContext(Global.DbFilePath);
            _suggestionsContext = new DBioPhotoContext(Global.DbFilePath);

            // Create the BackgroundWorker for loading of images, bind tasks for him
            LoadingImagesBgWorker = new BackgroundWorker();
            LoadingImagesBgWorker.DoWork += new DoWorkEventHandler(LoadingImagesBgWorker_DoWork);
            LoadingImagesBgWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(LoadingImagesBgWorker_RunWorkerEventCompleted);

            // Set all textboxes to autocomplete
            _suggestions = new AutoCompleteStringCollection();
            locationTextBox.AutoCompleteCustomSource = _suggestions;
            commentTextBox.AutoCompleteCustomSource = _suggestions;
            czFirstNameTextBox.AutoCompleteCustomSource = _suggestions;
            czSecondNameTextBox.AutoCompleteCustomSource = _suggestions;
            latFirstNameTextBox.AutoCompleteCustomSource = _suggestions;
            latSecondNameTextBox.AutoCompleteCustomSource = _suggestions;
            personNameTextBox.AutoCompleteCustomSource = _suggestions;
            personSurnameTextBox.AutoCompleteCustomSource = _suggestions;
            personNickTextBox.AutoCompleteCustomSource = _suggestions;
        }

        private void SearchingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SearchingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_searchingContext != null)
                _searchingContext.Dispose();
            if (_suggestionsContext != null)
                _suggestionsContext.Dispose();
        }



        // Change visibilty depending on what is the search based
        private void basedOnComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (basedOnComboBox.SelectedIndex)
            {
                case 0:
                    czNamesGroupBox.Visible = false;
                    latNamesGroupBox.Visible = false;
                    personNamesGroupBox.Visible = false;
                    break;
                case 1:
                    czNamesGroupBox.Visible = true;
                    latNamesGroupBox.Visible = false;
                    personNamesGroupBox.Visible = false;
                    break;
                case 2:
                    czNamesGroupBox.Visible = false;
                    latNamesGroupBox.Visible = true;
                    personNamesGroupBox.Visible = false;
                    break;
                case 3:
                    czNamesGroupBox.Visible = false;
                    latNamesGroupBox.Visible = false;
                    personNamesGroupBox.Visible = true;
                    break;
            }
        }



        private async void searchButton_Click(object sender, EventArgs e)
        {
            // Get data that are always used
            Category category = (Category)categoryComboBox.SelectedItem;
            DateTime fromDate = fromDateTimePicker.Value;
            DateTime untilDate = untilDateTimePicker.Value;
            string location = locationTextBox.Text.Trim().ToLower();
            string comment = commentTextBox.Text.Trim().ToLower();
            string[] names = new string[3];

            // Switch depending based on what is the search, get data from the form, check if valid, get the data from db in another thread,
            // await it, then run worker to view pictures from the paths
            switch (basedOnComboBox.SelectedIndex)
            {
                case 0:
                    await Task.Run(() => SearchPhotoLocking(_searchingContext, 0, names, (category, fromDate, untilDate, location, comment)));
                    break;
                case 1:
                    names[0] = czFirstNameTextBox.Text.Trim().ToLower();
                    names[1] = czSecondNameTextBox.Text.Trim().ToLower();
                    if (names[0] == "" || names[1] == "")
                        Global.ShowOnButtonForThreeSecs("Vyplňte jména", searchButton);
                    else
                        await Task.Run(() => SearchPhotoLocking(_searchingContext, 1, names, (category, fromDate, untilDate, location, comment)));
                    break;
                case 2:
                    names[0] = latFirstNameTextBox.Text.Trim().ToLower();
                    names[1] = latSecondNameTextBox.Text.Trim().ToLower();
                    if (names[0] == "" || names[1] == "")
                        Global.ShowOnButtonForThreeSecs("Vyplňte jména", searchButton);
                    else
                        await Task.Run(() => SearchPhotoLocking(_searchingContext, 2, names, (category, fromDate, untilDate, location, comment)));
                    break;
                case 3:
                    names[0] = personNameTextBox.Text.Trim().ToLower();
                    names[1] = personSurnameTextBox.Text.Trim().ToLower();
                    names[2] = personNickTextBox.Text.Trim().ToLower();
                    if (names[0] == "" || names[1] == "")
                        Global.ShowOnButtonForThreeSecs("Vyplňte jména", searchButton);
                    else
                        await Task.Run( () => SearchPhotoLocking(_searchingContext, 3, names, (category, fromDate, untilDate, location, comment)));
                    break;
            }
            LoadingImagesBgWorker.RunWorkerAsync();
        }

        // Lock dbcontext and query the searched stuff from there
        private void SearchPhotoLocking(DBioPhotoContext dbContext, int basedOn, string[] names, ValueTuple<Category, DateTime, DateTime, string, string> photoInfo)
        {
            string[] photosFound;
            lock (dbContext)
            {
                photosFound = SearchPhotos.SearchPhoto(dbContext, basedOn, names, photoInfo);
            }
            _imageRelativePaths = photosFound;
        }

        // Load images from paths got from db in the background, view it
        private void LoadingImagesBgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Reset the thumbnails and imagelist
            _imageThumbnails = new Image[_imageRelativePaths.Length];
            _imageList = new ImageList();

            // If there are any images, get thumbnails for them
            if (_imageRelativePaths.Length > 0)
                GetThumbnailsForImagesRelativePaths(_imageRelativePaths);
        }
        private void GetThumbnailsForImagesRelativePaths(string[] imageFilesRelativePath)
        {
            // Create absolutepaths and get the thumbnails from paths there
            string imageAbsolutePath;
            for (int i = 0; i < imageFilesRelativePath.Length; i++)
            {
                imageAbsolutePath = Global.RootFolder + imageFilesRelativePath[i];
                _imageThumbnails[i] = Image.FromFile(imageAbsolutePath).GetThumbnailImage(120, 90, new Image.GetThumbnailImageAbort(() => false), IntPtr.Zero);
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
            imagesListView.Items.Clear();
            if (_imageThumbnails != null && _imageRelativePaths != null && _imageThumbnails.Length == _imageRelativePaths.Length)
            {
                for (int itemIndex = 0; itemIndex < _imageThumbnails.Length; itemIndex++)
                {
                    imagesListView.Items.Add(new ListViewItem(Path.GetFileName(_imageRelativePaths[itemIndex]), itemIndex));
                }
            }
        }



        private void imagesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (imagesListView.SelectedIndices.Count > 0)
            {
                // When selecting an image, save the index and the path
                _selectedIndex = imagesListView.SelectedIndices[0];
                _showedImageRelativePath = _imageRelativePaths[_selectedIndex];
                _showedImagePath = Global.RootFolder + _showedImageRelativePath;

                // Dispose the old image, load new, get its datetime of creation / last write
                if (_showedImage != null)
                    _showedImage.Dispose();

                _showedImage = Image.FromFile(_showedImagePath);

                // View the image, view info in textboxes
                selectedImagePictureBox.Image = _showedImage;
                showedPhotoPathTextBox.Text = _showedImagePath;
            }
        }

        private void copyPathToClipboardButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(_showedImagePath);
        }
    }
}
