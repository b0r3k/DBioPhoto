using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DBioPhoto.Domain.Models;

namespace DBioPhoto.Frontend
{
    public partial class OrganismAddForm : Form
    {
        public OrganismAddForm()
        {
            InitializeComponent();

            organismTypeComboBox.DataSource = Enum.GetValues(typeof(OrganismType));
            colourComboBox.DataSource = Enum.GetValues(typeof(Colour));
        }

        private void addToDbButton_Click(object sender, EventArgs e)
        {

        }
    }
}
