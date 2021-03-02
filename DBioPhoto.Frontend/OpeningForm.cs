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
    public partial class OpeningForm : Form
    {
        public OpeningForm()
        {
            InitializeComponent();
            locationTextBox.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\DBioPhotoDB.mdf";
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
            string filePath = "";
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                openFileDialog.Filter = "mdf files (*.mdf)|*.mdf|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    locationTextBox.Text = filePath;
                }
            }
        }
    }
}
