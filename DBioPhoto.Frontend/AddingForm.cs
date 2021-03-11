using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DBioPhoto.Frontend
{
    public partial class AddingForm : Form
    {
        private string _folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private string[] _imagePaths;
        private ImageList _imageList;
        private Image[] ImageThumbnails { get; set; }
        private BackgroundWorker LoadingImagesBgWorker;
        public AddingForm()
        {
            InitializeComponent();
            this.Location = new System.Drawing.Point(0, 0);

            // Create the BackgroundWorker for adding, bind tasks for him
            LoadingImagesBgWorker = new BackgroundWorker();
            LoadingImagesBgWorker.DoWork += new DoWorkEventHandler(LoadingImagesBgWorker_DoWork);
            LoadingImagesBgWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(LoadingImagesBgWorker_RunWorkerEventCompleted);
        }

        private void LoadingImagesBgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Get all the images from selected directory
            _imagePaths = Directory.EnumerateFiles(_folderPath, "*.jpg*", SearchOption.TopDirectoryOnly)
                .Where(f => f.ToLower().EndsWith(".jpg") || f.ToLower().EndsWith(".jpeg") || f.ToLower().EndsWith(".png")).ToArray();
            
            // If there are any, get thumbnails for them
            if (_imagePaths.Length > 0)
                GetThumbnailsForImages(_imagePaths);
        }
        private void GetThumbnailsForImages(string[] imageFiles)
        {
            // Get the thumbnails from paths
            int numberImages = imageFiles.Length;
            ImageThumbnails = new Image[numberImages];
            for (int i = 0; i < numberImages; i++)
            {
                ImageThumbnails[i] = Image.FromFile(imageFiles[i]).GetThumbnailImage(120, 90, new Image.GetThumbnailImageAbort(() => false), IntPtr.Zero);
            }

            // Assign the thumbnails to the imageList
            _imageList = new ImageList();
            _imageList.ImageSize = new Size(120, 90);
            _imageList.Images.AddRange(ImageThumbnails);
        }

        private void LoadingImagesBgWorker_RunWorkerEventCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // View the imageList in imagesListView
            imagesListView.LargeImageList = _imageList;
            if (ImageThumbnails != null)
            {
                for (int itemIndex = 0; itemIndex < ImageThumbnails.Length; itemIndex++)
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
            // Load images in the background
            LoadingImagesBgWorker.RunWorkerAsync();
        }
    }
}
