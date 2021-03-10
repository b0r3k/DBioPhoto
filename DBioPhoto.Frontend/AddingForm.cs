using System;
using System.Windows.Forms;

namespace DBioPhoto.Frontend
{
    public partial class AddingForm : Form
    {
        private string _folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public AddingForm()
        {
            InitializeComponent();
            this.Location = new System.Drawing.Point(0, 0);
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
    }
}
