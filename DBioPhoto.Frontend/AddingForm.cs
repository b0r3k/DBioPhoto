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
        private List<Image> LoadedImages { get; set; }
        private ImageList _imageList;
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
            LoadImagesFromFolder(_folderPath);
        }
        private void LoadImagesFromFolder(string pathToFolder)
        {
            LoadedImages = new List<Image>();
            var files = Directory.EnumerateFiles(pathToFolder, "*.*", SearchOption.TopDirectoryOnly)
                .Where(f => f.ToLower().EndsWith(".jpg") || f.ToLower().EndsWith(".jpeg") || f.ToLower().EndsWith(".png"));
            foreach (var file in files)
            {
                LoadedImages.Add(Image.FromFile(file));
            }

            _imageList = new ImageList();
            _imageList.ImageSize = new Size(120, 90);
            _imageList.Images.AddRange(LoadedImages.ToArray());
        }

        private void LoadingImagesBgWorker_RunWorkerEventCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            imagesListView.LargeImageList = _imageList;

            for (int itemIndex = 0; itemIndex < LoadedImages.Count; itemIndex++)
            {
                imagesListView.Items.Add(new ListViewItem($"Image {itemIndex + 1}", itemIndex));
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
            LoadingImagesBgWorker.RunWorkerAsync();
        }
    }
}
