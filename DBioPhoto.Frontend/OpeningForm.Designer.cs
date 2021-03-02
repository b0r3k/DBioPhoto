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
            this.labelTODO1 = new System.Windows.Forms.Label();
            this.buttonWantAdd = new System.Windows.Forms.Button();
            this.buttonWantSearch = new System.Windows.Forms.Button();
            this.organismAddButton = new System.Windows.Forms.Button();
            this.personAddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWelcome.Location = new System.Drawing.Point(289, 29);
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
            this.labelLocation.Location = new System.Drawing.Point(64, 101);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(548, 15);
            this.labelLocation.TabIndex = 0;
            this.labelLocation.Text = "Standardní lokací pro databázový soubor je \"...\". Pokud chcete použít jiný, zvolt" +
    "e jeho lokaci v poli níže.";
            // 
            // labelTODO1
            // 
            this.labelTODO1.AutoSize = true;
            this.labelTODO1.Location = new System.Drawing.Point(214, 134);
            this.labelTODO1.Name = "labelTODO1";
            this.labelTODO1.Size = new System.Drawing.Size(255, 15);
            this.labelTODO1.TabIndex = 1;
            this.labelTODO1.Text = "TADY BUDE MÍSTO PRO ZVOLENÍ DB SOUBORU";
            // 
            // buttonWantAdd
            // 
            this.buttonWantAdd.Location = new System.Drawing.Point(148, 164);
            this.buttonWantAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonWantAdd.Name = "buttonWantAdd";
            this.buttonWantAdd.Size = new System.Drawing.Size(109, 22);
            this.buttonWantAdd.TabIndex = 2;
            this.buttonWantAdd.Text = "Chci přidávat!";
            this.buttonWantAdd.UseVisualStyleBackColor = true;
            this.buttonWantAdd.Click += new System.EventHandler(this.buttonWantAdd_Click);
            // 
            // buttonWantSearch
            // 
            this.buttonWantSearch.Location = new System.Drawing.Point(419, 164);
            this.buttonWantSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonWantSearch.Name = "buttonWantSearch";
            this.buttonWantSearch.Size = new System.Drawing.Size(109, 22);
            this.buttonWantSearch.TabIndex = 3;
            this.buttonWantSearch.Text = "Chci hledat!";
            this.buttonWantSearch.UseVisualStyleBackColor = true;
            this.buttonWantSearch.Click += new System.EventHandler(this.buttonWantSearch_Click);
            // 
            // organismAddButton
            // 
            this.organismAddButton.Location = new System.Drawing.Point(64, 216);
            this.organismAddButton.Name = "organismAddButton";
            this.organismAddButton.Size = new System.Drawing.Size(193, 23);
            this.organismAddButton.TabIndex = 4;
            this.organismAddButton.Text = "Přidávat organismy do databáze";
            this.organismAddButton.UseVisualStyleBackColor = true;
            this.organismAddButton.Click += new System.EventHandler(this.organismAddButton_Click);
            // 
            // personAddButton
            // 
            this.personAddButton.Location = new System.Drawing.Point(419, 216);
            this.personAddButton.Name = "personAddButton";
            this.personAddButton.Size = new System.Drawing.Size(193, 23);
            this.personAddButton.TabIndex = 5;
            this.personAddButton.Text = "Přidat lidi do databáze";
            this.personAddButton.UseVisualStyleBackColor = true;
            // 
            // OpeningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 260);
            this.Controls.Add(this.personAddButton);
            this.Controls.Add(this.organismAddButton);
            this.Controls.Add(this.buttonWantSearch);
            this.Controls.Add(this.buttonWantAdd);
            this.Controls.Add(this.labelTODO1);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.labelChoose);
            this.Controls.Add(this.labelWelcome);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OpeningForm";
            this.Text = "DBioPhoto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelChoose;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label labelTODO1;
        private System.Windows.Forms.Button buttonWantAdd;
        private System.Windows.Forms.Button buttonWantSearch;
        private System.Windows.Forms.Button organismAddButton;
        private System.Windows.Forms.Button personAddButton;
    }
}

