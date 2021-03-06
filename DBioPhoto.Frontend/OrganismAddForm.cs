using DBioPhoto.Domain.Models;
using System;
using System.ComponentModel;
using System.Windows.Forms;

using DBioPhoto.DataAccess.Services.Adding;

namespace DBioPhoto.Frontend
{
    public partial class OrganismAddForm : Form
    {
        private BackgroundWorker bgW1;
        private Organism tryOrganism;
        public OrganismAddForm()
        {
            InitializeComponent();

            // Populate the combo boxes with data from enums
            organismTypeComboBox.DataSource = Enum.GetValues(typeof(OrganismType));
            colourComboBox.DataSource = Enum.GetValues(typeof(Colour));

            // Create the BackgroundWorker, bind tasks for him
            bgW1 = new BackgroundWorker();
            bgW1.DoWork += new DoWorkEventHandler(BgW1_DoWork);
            bgW1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(BgW1_RunWorkerEventCompleted);
        }

        private void addToDbButton_Click(object sender, EventArgs e)
        {
            // Get the values from the form, create the instance of Organism
            OrganismType organismType = (OrganismType)organismTypeComboBox.SelectedItem;
            string firstName = firstNameTextBox.Text;
            string secondName = secondNameTextBox.Text;
            string latFirstName = latFirstNameTextBox.Text;
            string latSecondName = latSecondNameTextBox.Text;
            Colour colour = (Colour)colourComboBox.SelectedItem;

            tryOrganism = new Organism(organismType, firstName, secondName, latFirstName, latSecondName, colour);

            // Add to db in background
            addToDbButton.Text = "Přidávám!";
            bgW1.RunWorkerAsync(tryOrganism);

            // Reset the form
            firstNameTextBox.Text = "";
            secondNameTextBox.Text = "";
            latFirstNameTextBox.Text = "";
            latSecondNameTextBox.Text = "";
        }
        private void BgW1_DoWork(object sender, DoWorkEventArgs e)
        {
            // Add the created instance to the database
            // if (TryAddOrganism)
            e.Result = AddIndividual.TryAddOrganism(Global.DbContext, (Organism)e.Argument);
        }
        private void BgW1_RunWorkerEventCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
                MessageBox.Show(e.Error.Message);
            else if (e.Cancelled)
                ShowOnButtonForThreeSecs("Operace zrušena");
            else
            {
                string result = (string)e.Result;
                ShowOnButtonForThreeSecs(result);
                if (result != "Úspěšně přidáno!")
                    ShowOrganismInForm(tryOrganism);
            }
        }
        private void ShowOnButtonForThreeSecs(string textToShow)
        {
            // Show successfull, after 3 s show original again
            addToDbButton.Text = textToShow;
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer()
            {
                Interval = 3000,
                Enabled = true
            };
            timer.Tick += (sender, e) =>
            {
                addToDbButton.Text = "Přidat do databáze";
                timer.Dispose();
            };
        }
        private void ShowOrganismInForm(Organism organism)
        {
            firstNameTextBox.Text = organism.FirstName;
            secondNameTextBox.Text = organism.SecondName;
            latFirstNameTextBox.Text = organism.LatFirstName;
            latSecondNameTextBox.Text = organism.LatSecondName;
        }
    }
}
