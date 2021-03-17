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
            this.createDbLabel = new System.Windows.Forms.Label();
            this.createNewDbButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWelcome.Location = new System.Drawing.Point(274, 25);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(112, 41);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Vítejte!";
            // 
            // labelChoose
            // 
            this.labelChoose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelChoose.AutoSize = true;
            this.labelChoose.Location = new System.Drawing.Point(64, 82);
            this.labelChoose.Name = "labelChoose";
            this.labelChoose.Size = new System.Drawing.Size(529, 15);
            this.labelChoose.TabIndex = 0;
            this.labelChoose.Text = "Jako první vyberte databázový soubor. Jeho umístění také určuje kořenový adresář " +
    "pro adresy fotek.";
            // 
            // labelLocation
            // 
            this.labelLocation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(43, 108);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(571, 15);
            this.labelLocation.TabIndex = 0;
            this.labelLocation.Text = "Standardní lokací pro databázový soubor je Obrázky/DBioPhoto.mdf a kořenovým adre" +
    "sářem jsou Obrázky.";
            // 
            // wantAddButton
            // 
            this.wantAddButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.wantAddButton.Location = new System.Drawing.Point(138, 230);
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
            this.wantSearchButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.wantSearchButton.Location = new System.Drawing.Point(409, 230);
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
            this.organismAddButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.organismAddButton.Location = new System.Drawing.Point(54, 267);
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
            this.personAddButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.personAddButton.Location = new System.Drawing.Point(409, 267);
            this.personAddButton.Name = "personAddButton";
            this.personAddButton.Size = new System.Drawing.Size(193, 23);
            this.personAddButton.TabIndex = 5;
            this.personAddButton.Text = "Přidat lidi do databáze";
            this.personAddButton.UseVisualStyleBackColor = true;
            this.personAddButton.Visible = false;
            this.personAddButton.Click += new System.EventHandler(this.personAddButton_Click);
            // 
            // labelDifferentLocation
            // 
            this.labelDifferentLocation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelDifferentLocation.AutoSize = true;
            this.labelDifferentLocation.Location = new System.Drawing.Point(177, 132);
            this.labelDifferentLocation.Name = "labelDifferentLocation";
            this.labelDifferentLocation.Size = new System.Drawing.Size(293, 15);
            this.labelDifferentLocation.TabIndex = 6;
            this.labelDifferentLocation.Text = "Pokud chcete použít jiný, zvolte jeho lokaci v poli níže.";
            // 
            // locationTextBox
            // 
            this.locationTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.locationTextBox.Location = new System.Drawing.Point(164, 159);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(318, 23);
            this.locationTextBox.TabIndex = 7;
            this.locationTextBox.Click += new System.EventHandler(this.locationTextBox_Click);
            // 
            // chooseThisDbButton
            // 
            this.chooseThisDbButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chooseThisDbButton.Location = new System.Drawing.Point(250, 197);
            this.chooseThisDbButton.Name = "chooseThisDbButton";
            this.chooseThisDbButton.Size = new System.Drawing.Size(144, 23);
            this.chooseThisDbButton.TabIndex = 8;
            this.chooseThisDbButton.Text = "Zvolit tuto databázi";
            this.chooseThisDbButton.UseVisualStyleBackColor = true;
            this.chooseThisDbButton.Click += new System.EventHandler(this.chooseThisDbButton_Click);
            // 
            // createDbLabel
            // 
            this.createDbLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.createDbLabel.AutoSize = true;
            this.createDbLabel.Location = new System.Drawing.Point(177, 334);
            this.createDbLabel.Name = "createDbLabel";
            this.createDbLabel.Size = new System.Drawing.Size(277, 15);
            this.createDbLabel.TabIndex = 9;
            this.createDbLabel.Text = "Pokud chcete vytvořit novou databázi, klikněte zde:";
            // 
            // createNewDbButton
            // 
            this.createNewDbButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.createNewDbButton.Location = new System.Drawing.Point(250, 366);
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
            this.ClientSize = new System.Drawing.Size(664, 411);
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
            this.MinimumSize = new System.Drawing.Size(680, 450);
            this.Name = "OpeningForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DBioPhoto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OpeningForm_FormClosing);
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
        private System.Windows.Forms.Label createDbLabel;
        private System.Windows.Forms.Button createNewDbButton;
    }
}

