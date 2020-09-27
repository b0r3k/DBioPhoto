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
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWelcome.Location = new System.Drawing.Point(330, 39);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(138, 50);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Vítejte!";
            // 
            // labelChoose
            // 
            this.labelChoose.AutoSize = true;
            this.labelChoose.Location = new System.Drawing.Point(156, 105);
            this.labelChoose.Name = "labelChoose";
            this.labelChoose.Size = new System.Drawing.Size(470, 20);
            this.labelChoose.TabIndex = 0;
            this.labelChoose.Text = "Jako první vyberte, zda chcete do databáze přidávat, nebo v ní hledat.";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(73, 135);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(688, 20);
            this.labelLocation.TabIndex = 0;
            this.labelLocation.Text = "Standardní lokací pro databázový soubor je \"...\". Pokud chcete použít jiný, zvolt" +
    "e jeho lokaci v poli níže.";
            // 
            // labelTODO1
            // 
            this.labelTODO1.AutoSize = true;
            this.labelTODO1.Location = new System.Drawing.Point(245, 178);
            this.labelTODO1.Name = "labelTODO1";
            this.labelTODO1.Size = new System.Drawing.Size(325, 20);
            this.labelTODO1.TabIndex = 1;
            this.labelTODO1.Text = "TADY BUDE MÍSTO PRO ZVOLENÍ DB SOUBORU";
            // 
            // buttonWantAdd
            // 
            this.buttonWantAdd.Location = new System.Drawing.Point(191, 218);
            this.buttonWantAdd.Name = "buttonWantAdd";
            this.buttonWantAdd.Size = new System.Drawing.Size(125, 29);
            this.buttonWantAdd.TabIndex = 2;
            this.buttonWantAdd.Text = "Chci přidávat!";
            this.buttonWantAdd.UseVisualStyleBackColor = true;
            this.buttonWantAdd.Click += new System.EventHandler(this.buttonWantAdd_Click);
            // 
            // buttonWantSearch
            // 
            this.buttonWantSearch.Location = new System.Drawing.Point(485, 218);
            this.buttonWantSearch.Name = "buttonWantSearch";
            this.buttonWantSearch.Size = new System.Drawing.Size(125, 29);
            this.buttonWantSearch.TabIndex = 3;
            this.buttonWantSearch.Text = "Chci hledat!";
            this.buttonWantSearch.UseVisualStyleBackColor = true;
            this.buttonWantSearch.Click += new System.EventHandler(this.buttonWantSearch_Click);
            // 
            // OpeningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 279);
            this.Controls.Add(this.buttonWantSearch);
            this.Controls.Add(this.buttonWantAdd);
            this.Controls.Add(this.labelTODO1);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.labelChoose);
            this.Controls.Add(this.labelWelcome);
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
    }
}

