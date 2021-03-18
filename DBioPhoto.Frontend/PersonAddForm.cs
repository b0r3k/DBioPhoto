using DBioPhoto.DataAccess.Data;
using DBioPhoto.DataAccess.Services.Adding;
using DBioPhoto.Domain.Models;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBioPhoto.Frontend
{
    public partial class PersonAddForm : Form
    {
        // Collection for textboxes autocomplete
        private AutoCompleteStringCollection _nameSuggestions;

        // Instance of person for adding
        private Person _tryPerson;

        // DbContexts for communication with the db
        private DBioPhotoContext _addingContext;
        private DBioPhotoContext _suggestionsContext;

        public PersonAddForm()
        {
            InitializeComponent();

            // Set all the textboxes to autocomplete
            _nameSuggestions = new AutoCompleteStringCollection();
            nameTextBox.AutoCompleteCustomSource = _nameSuggestions;
            surnameTextBox.AutoCompleteCustomSource = _nameSuggestions;
            nickTextBox.AutoCompleteCustomSource = _nameSuggestions;

            // Initialize DbContexts
            _addingContext = new DBioPhotoContext(Global.DbFilePath);
            _suggestionsContext = new DBioPhotoContext(Global.DbFilePath);
        }

        private void addToDbButton_Click(object sender, System.EventArgs e)
        {
            // Get the values from form, create instance of Person
            string name = nameTextBox.Text.Trim().ToLower();
            string surname = surnameTextBox.Text.Trim().ToLower();
            string nick = nickTextBox.Text.Trim().ToLower();

            _tryPerson = new Person(name, nick, surname);

            // Add to ThreadPool task to TryAddPerson
            Task.Run(() => TryAddPersonLocking(_tryPerson));

            // Reset the form
            nameTextBox.Text = "";
            surnameTextBox.Text = "";
            nickTextBox.Text = "";
        }

        private void TryAddPersonLocking(Person tryPerson)
        {
            string result;
            // Lock the DbContext until finished
            lock (_addingContext)
            {
                result = AddIndividual.TryAddPerson(_addingContext, tryPerson);
            }
            // Invoke showing result on the main thread, if unsuccessfull, invoke also showing the person
            Invoke(new Action(() => Global.ShowOnButtonForTwoSecs(result, addToDbButton)));
            if (result != "Úspěšně přidáno!")
                Invoke(new Action(() => ShowPersonInForm(_tryPerson)));
        }
        private void ShowPersonInForm(Person person)
        {
            nameTextBox.Text = person.Name;
            surnameTextBox.Text = person.Surname;
            nickTextBox.Text = person.Nickname;
        }

        // When there are 3 chars in textbox and keyup, get autocomplete suggestions for that box in other thread
        private void nameTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t != null && t.Text.Length == 3)
            {
                Task.Run(() => GetPersonNameSuggestionsLocking(t.Text, 0));
            }
        }
        private void surnameTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t != null && t.Text.Length == 3)
            {
                Task.Run(() => GetPersonNameSuggestionsLocking(t.Text, 1));
            }
        }
        private void nickTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t != null && t.Text.Length == 3)
            {
                Task.Run(() => GetPersonNameSuggestionsLocking(t.Text, 2));
            }
        }
        // Get suggestions from db, lock context for it
        private void GetPersonNameSuggestionsLocking(string beginning, int textBoxNumber)
        {
            string[] result;
            // Lock the DbContext until finished
            lock (_suggestionsContext)
            {
                result = Suggestions.GetPersonNameSuggestions(_suggestionsContext, beginning, textBoxNumber);
            }
            // Invoke using results for autocomplete on the main thread
            Invoke(new Action(() => { _nameSuggestions.Clear(); _nameSuggestions.AddRange(result); }));
        }

        private void PersonAddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_addingContext != null)
                _addingContext.Dispose();
            if (_suggestionsContext != null)
                _suggestionsContext.Dispose();
        }
    }
}
