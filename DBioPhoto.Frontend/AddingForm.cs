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

namespace DBioPhoto.Frontend
{
    public partial class AddingForm : Form
    {
        private string _folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private string[] _imagePaths;
        private ImageList _imageList;
        private Image[] _imageThumbnails;
        private Image _showedImage;
        private string _showedImagePath;
        private DateTime _showedImageDate;
        private static Regex _regex = new Regex(":");
        private int _selectedIndex;
        private BackgroundWorker LoadingImagesBgWorker;
        public AddingForm()
        {
            InitializeComponent();
            this.Location = new System.Drawing.Point(0, 0);

            // Populate the combo box with data from enum
            categoryComboBox.DataSource = Enum.GetValues(typeof(Category));

            // Create the BackgroundWorker for adding, bind tasks for him
            LoadingImagesBgWorker = new BackgroundWorker();
            LoadingImagesBgWorker.DoWork += new DoWorkEventHandler(LoadingImagesBgWorker_DoWork);
            LoadingImagesBgWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(LoadingImagesBgWorker_RunWorkerEventCompleted);
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
            OrganismAddForm newGui = new OrganismAddForm();
            newGui.Visible = true;
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
            // When selecting an image, show it and save the index
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
    }
}
