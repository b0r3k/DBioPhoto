using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DBioPhoto.DataAccess.Data;
using DBioPhoto.Domain.Models;

namespace DBioPhoto.Frontend
{
    public partial class SearchingForm : Form
    {
        private DBioPhotoContext _searchingContext;
        private DBioPhotoContext _suggestionsContext;

        // Information about folder and thumbnails
        private string[] _imagePaths;
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

        }
    }
}
