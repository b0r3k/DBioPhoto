using DBioPhoto.DataAccess.Services.Adding;
using DBioPhoto.DataAccess.Data;
using DBioPhoto.Domain.Models;
using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBioPhoto.Frontend
{
    public partial class OrganismAddForm : Form
    {
        private BackgroundWorker AddingBgWorker;
        private BackgroundWorker SuggestionsBgWorker;
        private Organism _tryOrganism;
        private AutoCompleteStringCollection _nameSuggestions;
        private DBioPhotoContext _addingContext;
        private DBioPhotoContext _suggestionsContext;
        public OrganismAddForm()
        {
            InitializeComponent();

            // Populate the combo boxes with data from enums
            organismTypeComboBox.DataSource = Enum.GetValues(typeof(OrganismType));
            colourComboBox.DataSource = Enum.GetValues(typeof(Colour));

            // Create the DbContexts
            _addingContext = new DBioPhotoContext(Global.DbFilePath);
            _suggestionsContext = new DBioPhotoContext(Global.DbFilePath);
            
            // Set all the textboxes to autocomplete
            _nameSuggestions = new AutoCompleteStringCollection();
            firstNameTextBox.AutoCompleteCustomSource = _nameSuggestions;
            secondNameTextBox.AutoCompleteCustomSource = _nameSuggestions;
            latFirstNameTextBox.AutoCompleteCustomSource = _nameSuggestions;
            latSecondNameTextBox.AutoCompleteCustomSource = _nameSuggestions;
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

            _tryOrganism = new Organism(organismType, firstName, secondName, latFirstName, latSecondName, colour);

            // Add to ThreadPool task to TryAddPerson
            Task.Run(() => TryAddOrganismLocking(_tryOrganism));

            // Reset the form
            firstNameTextBox.Text = "";
            secondNameTextBox.Text = "";
            latFirstNameTextBox.Text = "";
            latSecondNameTextBox.Text = "";
        }
        private void TryAddOrganismLocking(Organism tryOrganism)
        {
            string result;
            // Lock the DbContext until finished
            lock (_addingContext)
            {
                result = AddIndividual.TryAddOrganism(_addingContext, tryOrganism);
            }
            // Invoke showing result on the main thread, if unsuccessfull, invoke also showing the organism
            Invoke(new Action(() => Global.ShowOnButtonForThreeSecs(result, addToDbButton)));
            if (result != "Úspěšně přidáno!")
                Invoke(new Action( () => ShowOrganismInForm(_tryOrganism) ));
        }
        private void ShowOrganismInForm(Organism organism)
        {
            firstNameTextBox.Text = organism.FirstName;
            secondNameTextBox.Text = organism.SecondName;
            latFirstNameTextBox.Text = organism.LatFirstName;
            latSecondNameTextBox.Text = organism.LatSecondName;
        }


        // When there are 3 chars in textbox and keyup, get autocomplete suggestions for that box in other thread
        private void firstNameTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t != null && t.Text.Length == 3)
            {
                Task.Run(() => GetOrganismNameSuggestionsLocking(t.Text, 0));
            }
        }
        private void secondNameTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t != null && t.Text.Length == 3)
            {
                Task.Run(() => GetOrganismNameSuggestionsLocking(t.Text, 1));
            }
        }
        private void latFirstNameTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t != null && t.Text.Length == 3)
            {
                Task.Run(() => GetOrganismNameSuggestionsLocking(t.Text, 2));
            }
        }
        private void latSecondNameTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t != null && t.Text.Length == 3)
            {
                Task.Run(() => GetOrganismNameSuggestionsLocking(t.Text, 3));
            }
        }

        // Get suggestions from db, lock context for it
        private void GetOrganismNameSuggestionsLocking(string beginning, int textBoxNumber)
        {
            string[] result;
            // Lock the DbContext until finished
            lock (_suggestionsContext)
            {
                result = Suggestions.GetOrganismNameSuggestions(_suggestionsContext, beginning, textBoxNumber);
            }
            // Invoke using results for autocomplete on the main thread
            Invoke(new Action(() => { _nameSuggestions.Clear(); _nameSuggestions.AddRange(result); }));
        }
    }
}