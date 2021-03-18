
namespace DBioPhoto.Frontend
{
    partial class OrganismAddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.secondNameLabel = new System.Windows.Forms.Label();
            this.latFirstNameLabel = new System.Windows.Forms.Label();
            this.latSecondNameLabel = new System.Windows.Forms.Label();
            this.colourLabel = new System.Windows.Forms.Label();
            this.organismTypeLabel = new System.Windows.Forms.Label();
            this.organismTypeComboBox = new System.Windows.Forms.ComboBox();
            this.latSecondNameTextBox = new System.Windows.Forms.TextBox();
            this.colourComboBox = new System.Windows.Forms.ComboBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.latFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.secondNameTextBox = new System.Windows.Forms.TextBox();
            this.addToDbButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(12, 59);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(114, 15);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "Český rodový název:";
            // 
            // secondNameLabel
            // 
            this.secondNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.secondNameLabel.AutoSize = true;
            this.secondNameLabel.Location = new System.Drawing.Point(12, 88);
            this.secondNameLabel.Name = "secondNameLabel";
            this.secondNameLabel.Size = new System.Drawing.Size(118, 15);
            this.secondNameLabel.TabIndex = 1;
            this.secondNameLabel.Text = "Český druhový název";
            // 
            // latFirstNameLabel
            // 
            this.latFirstNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.latFirstNameLabel.AutoSize = true;
            this.latFirstNameLabel.Location = new System.Drawing.Point(12, 117);
            this.latFirstNameLabel.Name = "latFirstNameLabel";
            this.latFirstNameLabel.Size = new System.Drawing.Size(123, 15);
            this.latFirstNameLabel.TabIndex = 2;
            this.latFirstNameLabel.Text = "Latinský rodový název";
            // 
            // latSecondNameLabel
            // 
            this.latSecondNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.latSecondNameLabel.AutoSize = true;
            this.latSecondNameLabel.Location = new System.Drawing.Point(12, 146);
            this.latSecondNameLabel.Name = "latSecondNameLabel";
            this.latSecondNameLabel.Size = new System.Drawing.Size(133, 15);
            this.latSecondNameLabel.TabIndex = 3;
            this.latSecondNameLabel.Text = "Latinský druhový název:";
            // 
            // colourLabel
            // 
            this.colourLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.colourLabel.AutoSize = true;
            this.colourLabel.Location = new System.Drawing.Point(12, 175);
            this.colourLabel.Name = "colourLabel";
            this.colourLabel.Size = new System.Drawing.Size(39, 15);
            this.colourLabel.TabIndex = 4;
            this.colourLabel.Text = "Barva:";
            // 
            // organismTypeLabel
            // 
            this.organismTypeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.organismTypeLabel.AutoSize = true;
            this.organismTypeLabel.Location = new System.Drawing.Point(12, 30);
            this.organismTypeLabel.Name = "organismTypeLabel";
            this.organismTypeLabel.Size = new System.Drawing.Size(88, 15);
            this.organismTypeLabel.TabIndex = 5;
            this.organismTypeLabel.Text = "Typ organismu:";
            // 
            // organismTypeComboBox
            // 
            this.organismTypeComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.organismTypeComboBox.DataSource = this.latSecondNameTextBox.Controls;
            this.organismTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.organismTypeComboBox.FormattingEnabled = true;
            this.organismTypeComboBox.Location = new System.Drawing.Point(168, 27);
            this.organismTypeComboBox.Name = "organismTypeComboBox";
            this.organismTypeComboBox.Size = new System.Drawing.Size(161, 23);
            this.organismTypeComboBox.TabIndex = 0;
            // 
            // latSecondNameTextBox
            // 
            this.latSecondNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.latSecondNameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.latSecondNameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.latSecondNameTextBox.Location = new System.Drawing.Point(168, 143);
            this.latSecondNameTextBox.Name = "latSecondNameTextBox";
            this.latSecondNameTextBox.Size = new System.Drawing.Size(161, 23);
            this.latSecondNameTextBox.TabIndex = 4;
            this.latSecondNameTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.latSecondNameTextBox_KeyUp);
            // 
            // colourComboBox
            // 
            this.colourComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.colourComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colourComboBox.FormattingEnabled = true;
            this.colourComboBox.Location = new System.Drawing.Point(168, 172);
            this.colourComboBox.Name = "colourComboBox";
            this.colourComboBox.Size = new System.Drawing.Size(161, 23);
            this.colourComboBox.TabIndex = 5;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.firstNameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.firstNameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.firstNameTextBox.Location = new System.Drawing.Point(168, 56);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(161, 23);
            this.firstNameTextBox.TabIndex = 1;
            this.firstNameTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.firstNameTextBox_KeyUp);
            // 
            // latFirstNameTextBox
            // 
            this.latFirstNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.latFirstNameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.latFirstNameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.latFirstNameTextBox.Location = new System.Drawing.Point(168, 114);
            this.latFirstNameTextBox.Name = "latFirstNameTextBox";
            this.latFirstNameTextBox.Size = new System.Drawing.Size(161, 23);
            this.latFirstNameTextBox.TabIndex = 3;
            this.latFirstNameTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.latFirstNameTextBox_KeyUp);
            // 
            // secondNameTextBox
            // 
            this.secondNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.secondNameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.secondNameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.secondNameTextBox.Location = new System.Drawing.Point(168, 85);
            this.secondNameTextBox.Name = "secondNameTextBox";
            this.secondNameTextBox.Size = new System.Drawing.Size(161, 23);
            this.secondNameTextBox.TabIndex = 2;
            this.secondNameTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.secondNameTextBox_KeyUp);
            // 
            // addToDbButton
            // 
            this.addToDbButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addToDbButton.Location = new System.Drawing.Point(96, 220);
            this.addToDbButton.Name = "addToDbButton";
            this.addToDbButton.Size = new System.Drawing.Size(145, 23);
            this.addToDbButton.TabIndex = 6;
            this.addToDbButton.Text = "Přidat do databáze";
            this.addToDbButton.UseVisualStyleBackColor = true;
            this.addToDbButton.Click += new System.EventHandler(this.addToDbButton_Click);
            // 
            // OrganismAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 271);
            this.Controls.Add(this.addToDbButton);
            this.Controls.Add(this.secondNameTextBox);
            this.Controls.Add(this.latSecondNameTextBox);
            this.Controls.Add(this.latFirstNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.colourComboBox);
            this.Controls.Add(this.organismTypeComboBox);
            this.Controls.Add(this.organismTypeLabel);
            this.Controls.Add(this.colourLabel);
            this.Controls.Add(this.latSecondNameLabel);
            this.Controls.Add(this.latFirstNameLabel);
            this.Controls.Add(this.secondNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.MinimumSize = new System.Drawing.Size(370, 310);
            this.Name = "OrganismAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrganismAddForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrganismAddForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label secondNameLabel;
        private System.Windows.Forms.Label latFirstNameLabel;
        private System.Windows.Forms.Label latSecondNameLabel;
        private System.Windows.Forms.Label colourLabel;
        private System.Windows.Forms.Label organismTypeLabel;
        private System.Windows.Forms.ComboBox organismTypeComboBox;
        private System.Windows.Forms.TextBox latSecondNameTextBox;
        private System.Windows.Forms.ComboBox colourComboBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox latFirstNameTextBox;
        private System.Windows.Forms.TextBox secondNameTextBox;
        private System.Windows.Forms.Button addToDbButton;
    }
}