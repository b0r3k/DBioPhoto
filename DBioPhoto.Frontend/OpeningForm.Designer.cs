namespace DBioPhoto.Frontend
{
    partial class OpeningForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelChoose = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.wantAddButton = new System.Windows.Forms.Button();
            this.wantSearchButton = new System.Windows.Forms.Button();
            this.organismAddButton = new System.Windows.Forms.Button();
            this.personAddButton = new System.Windows.Forms.Button();
            this.labelDifferentLocation = new System.Windows.Forms.Label();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.chooseThisDbButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.createDbLabel = new System.Windows.Forms.Label();
            this.createNewDbButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWelcome.Location = new System.Drawing.Point(272, 25);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(112, 41);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Vítejte!";
            // 
            // labelChoose
            // 
            this.labelChoose.AutoSize = true;
            this.labelChoose.Location = new System.Drawing.Point(136, 79);
            this.labelChoose.Name = "labelChoose";
            this.labelChoose.Size = new System.Drawing.Size(371, 15);
            this.labelChoose.TabIndex = 0;
            this.labelChoose.Text = "Jako první vyberte, zda chcete do databáze přidávat, nebo v ní hledat.";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(127, 106);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(389, 15);
            this.labelLocation.TabIndex = 0;
            this.labelLocation.Text = "Standardní lokací pro databázový soubor je Dokumenty/DBioPhoto.mdf.";
            // 
            // wantAddButton
            // 
            this.wantAddButton.Location = new System.Drawing.Point(136, 230);
            this.wantAddButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wantAddButton.Name = "wantAddButton";
            this.wantAddButton.Size = new System.Drawing.Size(109, 22);
            this.wantAddButton.TabIndex = 2;
            this.wantAddButton.Text = "Chci přidávat!";
            this.wantAddButton.UseVisualStyleBackColor = true;
            this.wantAddButton.Visible = false;
            this.wantAddButton.Click += new System.EventHandler(this.buttonWantAdd_Click);
            // 
            // wantSearchButton
            // 
            this.wantSearchButton.Location = new System.Drawing.Point(407, 230);
            this.wantSearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wantSearchButton.Name = "wantSearchButton";
            this.wantSearchButton.Size = new System.Drawing.Size(109, 22);
            this.wantSearchButton.TabIndex = 3;
            this.wantSearchButton.Text = "Chci hledat!";
            this.wantSearchButton.UseVisualStyleBackColor = true;
            this.wantSearchButton.Visible = false;
            this.wantSearchButton.Click += new System.EventHandler(this.buttonWantSearch_Click);
            // 
            // organismAddButton
            // 
            this.organismAddButton.Location = new System.Drawing.Point(52, 267);
            this.organismAddButton.Name = "organismAddButton";
            this.organismAddButton.Size = new System.Drawing.Size(193, 23);
            this.organismAddButton.TabIndex = 4;
            this.organismAddButton.Text = "Přidávat organismy do databáze";
            this.organismAddButton.UseVisualStyleBackColor = true;
            this.organismAddButton.Visible = false;
            this.organismAddButton.Click += new System.EventHandler(this.organismAddButton_Click);
            // 
            // personAddButton
            // 
            this.personAddButton.Location = new System.Drawing.Point(407, 267);
            this.personAddButton.Name = "personAddButton";
            this.personAddButton.Size = new System.Drawing.Size(193, 23);
            this.personAddButton.TabIndex = 5;
            this.personAddButton.Text = "Přidat lidi do databáze";
            this.personAddButton.UseVisualStyleBackColor = true;
            this.personAddButton.Visible = false;
            // 
            // labelDifferentLocation
            // 
            this.labelDifferentLocation.AutoSize = true;
            this.labelDifferentLocation.Location = new System.Drawing.Point(175, 132);
            this.labelDifferentLocation.Name = "labelDifferentLocation";
            this.labelDifferentLocation.Size = new System.Drawing.Size(293, 15);
            this.labelDifferentLocation.TabIndex = 6;
            this.labelDifferentLocation.Text = "Pokud chcete použít jiný, zvolte jeho lokaci v poli níže.";
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(162, 159);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(318, 23);
            this.locationTextBox.TabIndex = 7;
            this.locationTextBox.Click += new System.EventHandler(this.locationTextBox_Click);
            // 
            // chooseThisDbButton
            // 
            this.chooseThisDbButton.Location = new System.Drawing.Point(248, 197);
            this.chooseThisDbButton.Name = "chooseThisDbButton";
            this.chooseThisDbButton.Size = new System.Drawing.Size(144, 23);
            this.chooseThisDbButton.TabIndex = 8;
            this.chooseThisDbButton.Text = "Zvolit tuto databázi";
            this.chooseThisDbButton.UseVisualStyleBackColor = true;
            this.chooseThisDbButton.Click += new System.EventHandler(this.chooseThisDbButton_Click);
            // 
            // createDbLabel
            // 
            this.createDbLabel.AutoSize = true;
            this.createDbLabel.Location = new System.Drawing.Point(175, 334);
            this.createDbLabel.Name = "createDbLabel";
            this.createDbLabel.Size = new System.Drawing.Size(277, 15);
            this.createDbLabel.TabIndex = 9;
            this.createDbLabel.Text = "Pokud chcete vytvořit novou databázi, klikněte zde:";
            // 
            // createNewDbButton
            // 
            this.createNewDbButton.Location = new System.Drawing.Point(248, 366);
            this.createNewDbButton.Name = "createNewDbButton";
            this.createNewDbButton.Size = new System.Drawing.Size(144, 27);
            this.createNewDbButton.TabIndex = 10;
            this.createNewDbButton.Text = "Vytvořit novou databázi";
            this.createNewDbButton.UseVisualStyleBackColor = true;
            this.createNewDbButton.Click += new System.EventHandler(this.createNewDbButton_Click);
            // 
            // OpeningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 405);
            this.Controls.Add(this.createNewDbButton);
            this.Controls.Add(this.createDbLabel);
            this.Controls.Add(this.chooseThisDbButton);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.labelDifferentLocation);
            this.Controls.Add(this.personAddButton);
            this.Controls.Add(this.organismAddButton);
            this.Controls.Add(this.wantSearchButton);
            this.Controls.Add(this.wantAddButton);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.labelChoose);
            this.Controls.Add(this.labelWelcome);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OpeningForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DBioPhoto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelChoose;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Button wantAddButton;
        private System.Windows.Forms.Button wantSearchButton;
        private System.Windows.Forms.Button organismAddButton;
        private System.Windows.Forms.Button personAddButton;
        private System.Windows.Forms.Label labelDifferentLocation;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.Button chooseThisDbButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label createDbLabel;
        private System.Windows.Forms.Button createNewDbButton;
    }
}

