using System.Windows.Forms;

namespace DBioPhoto.Frontend
{
    public partial class AddingForm : Form
    {
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
    }
}
