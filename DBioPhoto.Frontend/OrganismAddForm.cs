using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

using DBioPhoto.Domain.Models;
using DBioPhoto.DataAccess;

namespace DBioPhoto.Frontend
{
    public partial class OrganismAddForm : Form
    {
        private BackgroundWorker bgW1;
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

            Organism organism = new Organism(organismType, firstName, secondName, latFirstName, latSecondName, colour);

            // Add to db in background
            addToDbButton.Text = "Přidávám!";
            bgW1.RunWorkerAsync(organism);

            // Reset the form
            firstNameTextBox.Text = "";
            secondNameTextBox.Text = "";
            latFirstNameTextBox.Text = "";
            latSecondNameTextBox.Text = "";
        }
        private void BgW1_DoWork(object sender, DoWorkEventArgs e)
        {
            // Add the created instance to the database
            Global.DbContext.Organisms.Add((Organism)e.Argument);
            Global.DbContext.SaveChanges();
        }
        private void BgW1_RunWorkerEventCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // TODO check errors, notification if already exists

            // TODO only if successfull
            ShowSuccessfull();
        }
        private void ShowSuccessfull()
        {
            addToDbButton.Text = "Úspěšně přidáno!";
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
