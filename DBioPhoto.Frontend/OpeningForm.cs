using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace DBioPhoto.Frontend
{
    public partial class OpeningForm : Form
    {
        private string _filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\DBioPhotoDB.mdf";
        private DataAccess.Data.DBioPhotoContext _dbContext;
        private Thread firstContextCreateThread, createContextThread;
        public OpeningForm()
        {
            InitializeComponent();
            locationTextBox.Text = _filePath;
        }

        private void SetActionButtonsVisible(bool setVisible)
        {
            wantAddButton.Visible = setVisible;
            wantSearchButton.Visible = setVisible;
            organismAddButton.Visible = setVisible;
            personAddButton.Visible = setVisible;
        }

        private void buttonWantAdd_Click(object sender, EventArgs e)
        {
            // If already opened, bring to front, else create new
            if (Application.OpenForms.OfType<AddingForm>().Count() == 1)
            {
                AddingForm openedForm = Application.OpenForms.OfType<AddingForm>().First();
                openedForm.WindowState = FormWindowState.Normal;
                openedForm.BringToFront();
            }
            else
            {
                AddingForm newGui = new AddingForm();
                newGui.Visible = true;
            }
            this.Visible = false;
        }

        private void buttonWantSearch_Click(object sender, EventArgs e)
        {
            // If already opened, bring to front, else create new
            if (Application.OpenForms.OfType<SearchingForm>().Count() == 1)
            {
                SearchingForm openedForm = Application.OpenForms.OfType<SearchingForm>().First();
                openedForm.WindowState = FormWindowState.Normal;
                openedForm.BringToFront();
            }
            else
            {
                SearchingForm newGui = new SearchingForm();
                newGui.Visible = true;
            }
            this.Visible = false;
        }

        private void organismAddButton_Click(object sender, EventArgs e)
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
                newGui.Visible = true;
            }
        }

        private void personAddButton_Click(object sender, EventArgs e)
        {
            // If already opened, bring to front, else create new
            if (Application.OpenForms.OfType<PersonAddForm>().Count() == 1)
            {
                PersonAddForm openedForm = Application.OpenForms.OfType<PersonAddForm>().First();
                openedForm.WindowState = FormWindowState.Normal;
                openedForm.BringToFront();
            }
            else
            {
                PersonAddForm newGui = new PersonAddForm();
                newGui.Visible = true;
            }
        }

        private void locationTextBox_Click(object sender, EventArgs e)
        {
            // Open OpenFileDialog and get path to the file chosen there
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                openFileDialog.Filter = "mdf files (*.mdf)|*.mdf";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    _filePath = openFileDialog.FileName;
                    locationTextBox.Text = _filePath;
                }
            }
        }

        private void chooseThisDbButton_Click(object sender, EventArgs e)
        {
            SetActionButtonsVisible(false);
            // If file exists, open db connection to it (create dbcontext in another thread), save RootFolder path and DbFile path
            if (File.Exists(_filePath))
            {
                Global.RootFolder = Path.GetDirectoryName(_filePath);
                Global.DbFilePath = _filePath;
                createContextThread = new Thread(() => CreateDbContext());
                createContextThread.Start();
                SetActionButtonsVisible(true);
            }
            else
                MessageBox.Show("První vytvořte databázi!");
        }
        private void CreateDbContext()
        {
            // Verify it's possible to create the dbcontext and there's database created, if creating first db, wait for it
            if (firstContextCreateThread != null && firstContextCreateThread.ThreadState == ThreadState.Running)
                firstContextCreateThread.Join();
            if (_dbContext != null)
            {
                _dbContext.SaveChanges();
                _dbContext.Dispose();
            }
            _dbContext = new DataAccess.Data.DBioPhotoContext(_filePath);
            _dbContext.Database.EnsureCreated();
            _dbContext.SaveChanges();
            _dbContext.Dispose();
        }

        private void createNewDbButton_Click(object sender, EventArgs e)
        {
            // Open SaveFileDialog, create new db where selected (in other thread)
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                saveFileDialog.Filter = "mdf files (*.mdf)|*.mdf";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.CheckFileExists = false;
                saveFileDialog.CheckPathExists = true;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _filePath = saveFileDialog.FileName;
                    firstContextCreateThread = new Thread(() => FirstCreateDbContext());
                    firstContextCreateThread.Start();
                    locationTextBox.Text = _filePath;
                    SetActionButtonsVisible(false);
                }
            }
        }

        private void FirstCreateDbContext()
        {
            // Create new db and db file where selected
            _dbContext = new DataAccess.Data.DBioPhotoContext(_filePath);
            _dbContext.Database.EnsureCreated();
            _dbContext.SaveChanges();
            _dbContext.Dispose();
            _dbContext = null;
        }

        private void OpeningForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_dbContext != null)
                _dbContext.Dispose();
        }
    }
}
