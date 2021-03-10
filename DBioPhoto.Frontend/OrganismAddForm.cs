using DBioPhoto.DataAccess.Services.Adding;
using DBioPhoto.Domain.Models;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace DBioPhoto.Frontend
{
    public partial class OrganismAddForm : Form
    {
        private BackgroundWorker AddingBgWorker;
        private BackgroundWorker SuggestionsBgWorker;
        private Organism tryOrganism;
        private AutoCompleteStringCollection nameSuggestions;
        public OrganismAddForm()
        {
            InitializeComponent();
            // Set the location
            this.Location = new System.Drawing.Point(1536, 0);

            // Populate the combo boxes with data from enums
            organismTypeComboBox.DataSource = Enum.GetValues(typeof(OrganismType));
            colourComboBox.DataSource = Enum.GetValues(typeof(Colour));

            // Create the BackgroundWorker for adding, bind tasks for him
            AddingBgWorker = new BackgroundWorker();
            AddingBgWorker.DoWork += new DoWorkEventHandler(AddingBgWorker_DoWork);
            AddingBgWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(AddingBgWorker_RunWorkerEventCompleted);

            // Create the BackgroundWorker for suggestions, bind tasks for him
            SuggestionsBgWorker = new BackgroundWorker();
            SuggestionsBgWorker.DoWork += new DoWorkEventHandler(SuggestionsBgWorker_DoWork);
            SuggestionsBgWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(SuggestionsBgWorker_RunWorkerEventCompleted);
            
            // Set all the textboxes to autocomplete
            nameSuggestions = new AutoCompleteStringCollection();
            firstNameTextBox.AutoCompleteCustomSource = nameSuggestions;
            secondNameTextBox.AutoCompleteCustomSource = nameSuggestions;
            latFirstNameTextBox.AutoCompleteCustomSource = nameSuggestions;
            latSecondNameTextBox.AutoCompleteCustomSource = nameSuggestions;
        }

        private void addToDbButton_Click(object sender, EventArgs e)
        {
            // Get the values from the form, lowecase everything, create the instance of Organism
            OrganismType organismType = (OrganismType)organismTypeComboBox.SelectedItem;
            string firstName = firstNameTextBox.Text.Trim().ToLower();
            string secondName = secondNameTextBox.Text.Trim().ToLower();
            string latFirstName = latFirstNameTextBox.Text.Trim().ToLower();
            string latSecondName = latSecondNameTextBox.Text.Trim().ToLower();
            Colour colour = (Colour)colourComboBox.SelectedItem;

            tryOrganism = new Organism(organismType, firstName, secondName, latFirstName, latSecondName, colour);

            // Add to db in background
            addToDbButton.Text = "Přidávám!";
            AddingBgWorker.RunWorkerAsync(tryOrganism);

            // Reset the form
            firstNameTextBox.Text = "";
            secondNameTextBox.Text = "";
            latFirstNameTextBox.Text = "";
            latSecondNameTextBox.Text = "";
        }
        private void AddingBgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Add the created instance to the database
            e.Result = AddIndividual.TryAddOrganism(Global.DbContext, (Organism)e.Argument);
        }
        private void AddingBgWorker_RunWorkerEventCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Check if the organism was added successfully, show result, if not successfull, refill the form
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
            // Show textToShow on the button, after 3 s show original again
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


        // Find suggestions in db in the background if there are 3 chars in the textbox
        private void firstNameTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t != null)
            {
                if (t.Text.Length == 3)
                {
                    SuggestionsBgWorker.RunWorkerAsync((t.Text, 0));
                }
            }
        }
        private void secondNameTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t != null)
            {
                if (t.Text.Length == 3)
                {
                    SuggestionsBgWorker.RunWorkerAsync((t.Text, 1));
                }
            }
        }

        private void latFirstNameTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t != null)
            {
                if (t.Text.Length == 3)
                {
                    SuggestionsBgWorker.RunWorkerAsync((t.Text, 2));
                }
            }
        }

        private void latSecondNameTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t != null)
            {
                if (t.Text.Length == 3)
                {
                    SuggestionsBgWorker.RunWorkerAsync((t.Text, 3));
                }
            }
        }

        private void SuggestionsBgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Find the suggestions in the background
            (string beginning, int textBoxNumber) = (ValueTuple<string, int>)e.Argument;
            e.Result = Suggestions.GetOrganismNameSuggestions(Global.DbContext, beginning, textBoxNumber);
        }
        private void SuggestionsBgWorker_RunWorkerEventCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // After finding the suggestions, use them
            if (e.Error != null)
                MessageBox.Show(e.Error.Message);
            else if (e.Cancelled)
                MessageBox.Show("Operace zrušena");
            else
            {
                nameSuggestions.Clear();
                nameSuggestions.AddRange((string[])e.Result);
            }
        }
    }
}