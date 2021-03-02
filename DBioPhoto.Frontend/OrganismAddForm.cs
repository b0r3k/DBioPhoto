using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DBioPhoto.Domain.Models;
using DBioPhoto.DataAccess;

namespace DBioPhoto.Frontend
{
    public partial class OrganismAddForm : Form
    {
        public OrganismAddForm()
        {
            InitializeComponent();

            // Populate the combo boxes with data from enums
            organismTypeComboBox.DataSource = Enum.GetValues(typeof(OrganismType));
            colourComboBox.DataSource = Enum.GetValues(typeof(Colour));
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

            Organism organism = new Organism(organismType, firstName, secondName, latFirstName, latSecondName, colour);

            // Add the created instance to the database
            using (var context = new DBioPhoto.DataAccess.Data.DBioPhotoContext())
            {
                context.Organisms.Add(organism);
                context.SaveChanges();
            }
            addToDbButton.Text = "Úspěšně přidáno!";

            // Reset the form
            firstNameTextBox.Text = "";
            secondNameTextBox.Text = "";
            latFirstNameTextBox.Text = "";
            latSecondNameTextBox.Text = "";

            Timer timer = new Timer()
            {
                Interval = 3000,
                Enabled = true
            };
            timer.Tick += (sender, e) => {
                addToDbButton.Text = "Přidat do databáze";
                timer.Dispose();
            };
        }
    }
}
