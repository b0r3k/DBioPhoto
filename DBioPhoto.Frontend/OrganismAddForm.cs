using DBioPhoto.Domain.Models;
using System;
using System.ComponentModel;
using System.Windows.Forms;

using DBioPhoto.DataAccess.Services.Adding;
using System.Linq;

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

            // Set all the textboxes to autocomplete
            firstNameTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            firstNameTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            secondNameTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            secondNameTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            latFirstNameTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            latFirstNameTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            latSecondNameTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            latSecondNameTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void addToDbButton_Click(object sender, EventArgs e)
        {
            // Get the values from the form, create the instance of Organism
            OrganismType organismType = (OrganismType)organismTypeComboBox.SelectedItem;
            string firstName = firstNameTextBox.Text.Trim().ToLower();
            string secondName = secondNameTextBox.Text.Trim().ToLower();
            string latFirstName = latFirstNameTextBox.Text.Trim().ToLower();
            string latSecondName = latSecondNameTextBox.Text.Trim().ToLower();
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

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (firstNameTextBox.Text.Length >= 3)
            {
                string[] suggestions = Global.DbContext.Organisms.Where(o => o.FirstName.Contains(firstNameTextBox.Text)).Distinct().Select(o => o.FirstName).ToArray();

                AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
                collection.AddRange(suggestions);

                firstNameTextBox.AutoCompleteCustomSource = collection;
            }
        }
    }
}