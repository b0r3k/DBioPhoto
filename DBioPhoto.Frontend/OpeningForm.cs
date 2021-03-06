using System;
using System.Threading;
using System.Windows.Forms;

namespace DBioPhoto.Frontend
{
    /*
    Zadám složku, ono to postupně otevírá fotky a nechává si dopsat informace

    -- typ -- krajina, rostliny, houby, živočichové, mikro, lidi - případně možnost přidat typ
    -- český a latinský název -- dělit na rodové a druhové jméno
    -- datum(na různých úrovních, měsíc, rok, rozmezí)
    -- lokalita, případně kreslit do mapy
    -- obecná textová poznámka
    -- případně u živočichů bezobratlí/obratlovci, při dalším přidání to už podle rodového jména doplní
    -- případně u rostlin byliny/stromy/keře/výtrusné
    -- barva květu -- bílá, žlutá, červená, růžová, fialová, zelená a nevytvořený, modrá
        -- kliknout na místo a z okolních pixelů vybrat barvu, která je nejblíž
    -- možná přístupná databáze biolib, ze které by se daly tahat další informace
    */
    public partial class OpeningForm : Form
    {
        private string _filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\DBioPhotoDB.mdf";
        private Thread firstContextCreateThread, createContextThread;
        public OpeningForm()
        {
            InitializeComponent();
            locationTextBox.Text = _filePath;
            firstContextCreateThread = new Thread(() => FirstCreateDbContext());
            createContextThread = new Thread(() => CreateDbContext());
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

        }

        private void buttonWantSearch_Click(object sender, EventArgs e)
        {

        }

        private void organismAddButton_Click(object sender, EventArgs e)
        {
            OrganismAddForm newGui = new OrganismAddForm();
            newGui.Visible = true;
        }

        private void locationTextBox_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
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
            createContextThread.Start();
            SetActionButtonsVisible(true);
        }
        private void CreateDbContext()
        {
            if (firstContextCreateThread.ThreadState == ThreadState.Running)
                firstContextCreateThread.Join();
            if (Global.DbContext != null)
            {
                Global.DbContext.SaveChanges();
                Global.DbContext.Dispose();
            }
            Global.DbContext = new DataAccess.Data.DBioPhotoContext(_filePath);
            Global.DbContext.Database.EnsureCreated();
        }

        private void createNewDbButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                saveFileDialog.Filter = "mdf files (*.mdf)|*.mdf";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.CheckFileExists = false;
                saveFileDialog.CheckPathExists = true;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _filePath = saveFileDialog.FileName;
                    firstContextCreateThread.Start();
                    locationTextBox.Text = _filePath;
                    SetActionButtonsVisible(false);
                }
            }
        }
        private void FirstCreateDbContext()
        {
            Global.DbContext = new DataAccess.Data.DBioPhotoContext(_filePath);
            Global.DbContext.Database.EnsureCreated();
            Global.DbContext.SaveChanges();
            Global.DbContext.Dispose();
            Global.DbContext = null;
        }
    }
}
