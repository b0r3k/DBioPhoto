using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public OpeningForm()
        {
            InitializeComponent();
            locationTextBox.Text = _filePath;
        }

        private void ToggleActionButtons()
        {
            if (wantAddButton.Visible)
            {
                wantAddButton.Visible = false;
                wantSearchButton.Visible = false;
                organismAddButton.Visible = false;
                personAddButton.Visible = false;
            }
            else
            {
                wantAddButton.Visible = true;
                wantSearchButton.Visible = true;
                organismAddButton.Visible = true;
                personAddButton.Visible = true;
            }
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
                openFileDialog.Filter = "mdf files (*.mdf)|*.mdf|All files (*.*)|*.*";
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
            Global.DbContext = new DataAccess.Data.DBioPhotoContext(_filePath);
            ToggleActionButtons();
        }
    }
}
