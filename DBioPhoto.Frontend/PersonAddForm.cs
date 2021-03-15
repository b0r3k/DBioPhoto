using System.Windows.Forms;
using DBioPhoto.Domain.Models;
using DBioPhoto.DataAccess.Services.Adding;
using System;
using System.Threading.Tasks;

namespace DBioPhoto.Frontend
{
    public partial class PersonAddForm : Form
    {
        private AutoCompleteStringCollection _nameSuggestions;
        private Person _tryPerson;
        public PersonAddForm()
        {
            InitializeComponent();

            // Set all the textboxes to autocomplete
            _nameSuggestions = new AutoCompleteStringCollection();
            nameTextBox.AutoCompleteCustomSource = _nameSuggestions;
            surnameTextBox.AutoCompleteCustomSource = _nameSuggestions;
            nickTextBox.AutoCompleteCustomSource = _nameSuggestions;

            Global.DbContext = new DataAccess.Data.DBioPhotoContext(Global.DbFilePath);
        }

        private void addToDbButton_Click(object sender, System.EventArgs e)
        {
            string name = nameTextBox.Text.Trim().ToLower();
            string surname = surnameTextBox.Text.Trim().ToLower();
            string nick = nickTextBox.Text.Trim().ToLower();

            _tryPerson = new Person(name, nick, surname);

            Task.Run(() => TryAddPersonInAnotherThread(this, _tryPerson));
        }

        private void TryAddPersonInAnotherThread(PersonAddForm form, Person tryPerson)
        {
            string result;
            lock (Global.DbContext)
            {
                result = AddIndividual.TryAddPerson(Global.DbContext, tryPerson);
                Global.DbContext.SaveChanges();
            }
            form.Invoke(new Action( () => form.ShowOnButtonForThreeSecs(result) ));
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
    }
}
