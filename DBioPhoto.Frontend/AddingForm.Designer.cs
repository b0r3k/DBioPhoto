
namespace DBioPhoto.Frontend
{
    partial class AddingForm
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
            this.organismAddButton = new System.Windows.Forms.Button();
            this.folderPathTextBox = new System.Windows.Forms.TextBox();
            this.folderChooseButton = new System.Windows.Forms.Button();
            this.folderChooseLabel = new System.Windows.Forms.Label();
            this.imagesListView = new System.Windows.Forms.ListView();
            this.selectedImagePictureBox = new System.Windows.Forms.PictureBox();
            this.showedPhotoPathLabel = new System.Windows.Forms.Label();
            this.showedPhotoPathTextBox = new System.Windows.Forms.TextBox();
            this.showedPhotoDateLabel = new System.Windows.Forms.Label();
            this.showedPhotoDateTextBox = new System.Windows.Forms.TextBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.commentLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.addPhotoToDbButton = new System.Windows.Forms.Button();
            this.showedPhotoRelativePathLabel = new System.Windows.Forms.Label();
            this.showedPhotoRelativePathTextBox = new System.Windows.Forms.TextBox();
            this.organismsOnPhotoListBox = new System.Windows.Forms.ListBox();
            this.peopleOnPhotoListBox = new System.Windows.Forms.ListBox();
            this.removeOrganismFromPhotoButton = new System.Windows.Forms.Button();
            this.removePersonFromPhotoButton = new System.Windows.Forms.Button();
            this.organismNameLabel = new System.Windows.Forms.Label();
            this.personNameOrNickLabel = new System.Windows.Forms.Label();
            this.organismNameTextBox = new System.Windows.Forms.TextBox();
            this.addOrganismToPhotoButton = new System.Windows.Forms.Button();
            this.personNameOrNickTextBox = new System.Windows.Forms.TextBox();
            this.addPersonToPhotoButton = new System.Windows.Forms.Button();
            this.personAddButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.selectedImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // organismAddButton
            // 
            this.organismAddButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.organismAddButton.Location = new System.Drawing.Point(1313, 394);
            this.organismAddButton.Name = "organismAddButton";
            this.organismAddButton.Size = new System.Drawing.Size(124, 23);
            this.organismAddButton.TabIndex = 0;
            this.organismAddButton.Text = "Přidávat organismy";
            this.organismAddButton.UseVisualStyleBackColor = true;
            this.organismAddButton.Click += new System.EventHandler(this.organismAddButton_Click);
            // 
            // folderPathTextBox
            // 
            this.folderPathTextBox.Location = new System.Drawing.Point(32, 38);
            this.folderPathTextBox.Name = "folderPathTextBox";
            this.folderPathTextBox.Size = new System.Drawing.Size(599, 23);
            this.folderPathTextBox.TabIndex = 1;
            this.folderPathTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.folderPathTextBox_MouseClick);
            // 
            // folderChooseButton
            // 
            this.folderChooseButton.Location = new System.Drawing.Point(649, 38);
            this.folderChooseButton.Name = "folderChooseButton";
            this.folderChooseButton.Size = new System.Drawing.Size(120, 23);
            this.folderChooseButton.TabIndex = 2;
            this.folderChooseButton.Text = "Zvolit složku";
            this.folderChooseButton.UseVisualStyleBackColor = true;
            this.folderChooseButton.Click += new System.EventHandler(this.folderChooseButton_Click);
            // 
            // folderChooseLabel
            // 
            this.folderChooseLabel.AutoSize = true;
            this.folderChooseLabel.Location = new System.Drawing.Point(32, 20);
            this.folderChooseLabel.Name = "folderChooseLabel";
            this.folderChooseLabel.Size = new System.Drawing.Size(212, 15);
            this.folderChooseLabel.TabIndex = 3;
            this.folderChooseLabel.Text = "Zvolte složku, kterou chcete procházet:";
            // 
            // imagesListView
            // 
            this.imagesListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imagesListView.HideSelection = false;
            this.imagesListView.Location = new System.Drawing.Point(32, 782);
            this.imagesListView.MultiSelect = false;
            this.imagesListView.Name = "imagesListView";
            this.imagesListView.Size = new System.Drawing.Size(900, 216);
            this.imagesListView.TabIndex = 4;
            this.imagesListView.UseCompatibleStateImageBehavior = false;
            this.imagesListView.SelectedIndexChanged += new System.EventHandler(this.imagesListView_SelectedIndexChanged);
            // 
            // selectedImagePictureBox
            // 
            this.selectedImagePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedImagePictureBox.Location = new System.Drawing.Point(32, 83);
            this.selectedImagePictureBox.Name = "selectedImagePictureBox";
            this.selectedImagePictureBox.Size = new System.Drawing.Size(900, 675);
            this.selectedImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.selectedImagePictureBox.TabIndex = 5;
            this.selectedImagePictureBox.TabStop = false;
            // 
            // showedPhotoPathLabel
            // 
            this.showedPhotoPathLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showedPhotoPathLabel.AutoSize = true;
            this.showedPhotoPathLabel.Location = new System.Drawing.Point(947, 86);
            this.showedPhotoPathLabel.Name = "showedPhotoPathLabel";
            this.showedPhotoPathLabel.Size = new System.Drawing.Size(39, 15);
            this.showedPhotoPathLabel.TabIndex = 6;
            this.showedPhotoPathLabel.Text = "Cesta:";
            // 
            // showedPhotoPathTextBox
            // 
            this.showedPhotoPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showedPhotoPathTextBox.Location = new System.Drawing.Point(1157, 83);
            this.showedPhotoPathTextBox.Name = "showedPhotoPathTextBox";
            this.showedPhotoPathTextBox.ReadOnly = true;
            this.showedPhotoPathTextBox.Size = new System.Drawing.Size(231, 23);
            this.showedPhotoPathTextBox.TabIndex = 7;
            // 
            // showedPhotoDateLabel
            // 
            this.showedPhotoDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showedPhotoDateLabel.AutoSize = true;
            this.showedPhotoDateLabel.Location = new System.Drawing.Point(947, 158);
            this.showedPhotoDateLabel.Name = "showedPhotoDateLabel";
            this.showedPhotoDateLabel.Size = new System.Drawing.Size(74, 15);
            this.showedPhotoDateLabel.TabIndex = 8;
            this.showedPhotoDateLabel.Text = "Čas pořízení:";
            // 
            // showedPhotoDateTextBox
            // 
            this.showedPhotoDateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showedPhotoDateTextBox.Location = new System.Drawing.Point(1157, 155);
            this.showedPhotoDateTextBox.Name = "showedPhotoDateTextBox";
            this.showedPhotoDateTextBox.ReadOnly = true;
            this.showedPhotoDateTextBox.Size = new System.Drawing.Size(231, 23);
            this.showedPhotoDateTextBox.TabIndex = 9;
            // 
            // categoryLabel
            // 
            this.categoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(947, 192);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(60, 15);
            this.categoryLabel.TabIndex = 10;
            this.categoryLabel.Text = "Kategorie:";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(1157, 189);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(231, 23);
            this.categoryComboBox.TabIndex = 11;
            // 
            // commentLabel
            // 
            this.commentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.commentLabel.AutoSize = true;
            this.commentLabel.Location = new System.Drawing.Point(947, 268);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(65, 15);
            this.commentLabel.TabIndex = 12;
            this.commentLabel.Text = "Poznámka:";
            // 
            // locationLabel
            // 
            this.locationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(947, 230);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(85, 15);
            this.locationLabel.TabIndex = 13;
            this.locationLabel.Text = "Místo pořízení:";
            // 
            // locationTextBox
            // 
            this.locationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.locationTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.locationTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.locationTextBox.Location = new System.Drawing.Point(1157, 227);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(231, 23);
            this.locationTextBox.TabIndex = 14;
            this.locationTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.locationTextBox_KeyUp);
            // 
            // commentTextBox
            // 
            this.commentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.commentTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.commentTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.commentTextBox.Location = new System.Drawing.Point(1157, 265);
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(231, 23);
            this.commentTextBox.TabIndex = 15;
            this.commentTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.commentTextBox_KeyUp);
            // 
            // addPhotoToDbButton
            // 
            this.addPhotoToDbButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addPhotoToDbButton.Location = new System.Drawing.Point(1086, 303);
            this.addPhotoToDbButton.Name = "addPhotoToDbButton";
            this.addPhotoToDbButton.Size = new System.Drawing.Size(145, 23);
            this.addPhotoToDbButton.TabIndex = 16;
            this.addPhotoToDbButton.Text = "Přidat fotku do databáze";
            this.addPhotoToDbButton.UseVisualStyleBackColor = true;
            this.addPhotoToDbButton.Click += new System.EventHandler(this.addPhotoToDbButton_Click);
            // 
            // showedPhotoRelativePathLabel
            // 
            this.showedPhotoRelativePathLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showedPhotoRelativePathLabel.AutoSize = true;
            this.showedPhotoRelativePathLabel.Location = new System.Drawing.Point(947, 120);
            this.showedPhotoRelativePathLabel.Name = "showedPhotoRelativePathLabel";
            this.showedPhotoRelativePathLabel.Size = new System.Drawing.Size(204, 15);
            this.showedPhotoRelativePathLabel.TabIndex = 17;
            this.showedPhotoRelativePathLabel.Text = "Relativní cesta (uložena do databáze):";
            // 
            // showedPhotoRelativePathTextBox
            // 
            this.showedPhotoRelativePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showedPhotoRelativePathTextBox.Location = new System.Drawing.Point(1157, 117);
            this.showedPhotoRelativePathTextBox.Name = "showedPhotoRelativePathTextBox";
            this.showedPhotoRelativePathTextBox.ReadOnly = true;
            this.showedPhotoRelativePathTextBox.Size = new System.Drawing.Size(231, 23);
            this.showedPhotoRelativePathTextBox.TabIndex = 18;
            // 
            // organismsOnPhotoListBox
            // 
            this.organismsOnPhotoListBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.organismsOnPhotoListBox.FormattingEnabled = true;
            this.organismsOnPhotoListBox.ItemHeight = 15;
            this.organismsOnPhotoListBox.Location = new System.Drawing.Point(947, 394);
            this.organismsOnPhotoListBox.Name = "organismsOnPhotoListBox";
            this.organismsOnPhotoListBox.Size = new System.Drawing.Size(360, 154);
            this.organismsOnPhotoListBox.TabIndex = 19;
            // 
            // peopleOnPhotoListBox
            // 
            this.peopleOnPhotoListBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.peopleOnPhotoListBox.FormattingEnabled = true;
            this.peopleOnPhotoListBox.ItemHeight = 15;
            this.peopleOnPhotoListBox.Location = new System.Drawing.Point(947, 619);
            this.peopleOnPhotoListBox.Name = "peopleOnPhotoListBox";
            this.peopleOnPhotoListBox.Size = new System.Drawing.Size(360, 139);
            this.peopleOnPhotoListBox.TabIndex = 20;
            // 
            // removeOrganismFromPhotoButton
            // 
            this.removeOrganismFromPhotoButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.removeOrganismFromPhotoButton.Location = new System.Drawing.Point(1313, 509);
            this.removeOrganismFromPhotoButton.Name = "removeOrganismFromPhotoButton";
            this.removeOrganismFromPhotoButton.Size = new System.Drawing.Size(124, 39);
            this.removeOrganismFromPhotoButton.TabIndex = 21;
            this.removeOrganismFromPhotoButton.Text = "Odebrat organismus z fotky";
            this.removeOrganismFromPhotoButton.UseVisualStyleBackColor = true;
            this.removeOrganismFromPhotoButton.Click += new System.EventHandler(this.removeOrganismFromPhotoButton_Click);
            // 
            // removePersonFromPhotoButton
            // 
            this.removePersonFromPhotoButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.removePersonFromPhotoButton.Location = new System.Drawing.Point(1313, 719);
            this.removePersonFromPhotoButton.Name = "removePersonFromPhotoButton";
            this.removePersonFromPhotoButton.Size = new System.Drawing.Size(124, 39);
            this.removePersonFromPhotoButton.TabIndex = 22;
            this.removePersonFromPhotoButton.Text = "Odebrat člověka z fotky";
            this.removePersonFromPhotoButton.UseVisualStyleBackColor = true;
            this.removePersonFromPhotoButton.Click += new System.EventHandler(this.removePersonFromPhotoButton_Click);
            // 
            // organismNameLabel
            // 
            this.organismNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.organismNameLabel.AutoSize = true;
            this.organismNameLabel.Location = new System.Drawing.Point(947, 347);
            this.organismNameLabel.Name = "organismNameLabel";
            this.organismNameLabel.Size = new System.Drawing.Size(207, 15);
            this.organismNameLabel.TabIndex = 23;
            this.organismNameLabel.Text = "Český nebo latinský název organismu:";
            // 
            // personNameOrNickLabel
            // 
            this.personNameOrNickLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.personNameOrNickLabel.AutoSize = true;
            this.personNameOrNickLabel.Location = new System.Drawing.Point(947, 572);
            this.personNameOrNickLabel.Name = "personNameOrNickLabel";
            this.personNameOrNickLabel.Size = new System.Drawing.Size(227, 15);
            this.personNameOrNickLabel.TabIndex = 24;
            this.personNameOrNickLabel.Text = "Jméno a příjmení nebo přezdívka člověka:";
            // 
            // organismNameTextBox
            // 
            this.organismNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.organismNameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.organismNameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.organismNameTextBox.Location = new System.Drawing.Point(947, 365);
            this.organismNameTextBox.Name = "organismNameTextBox";
            this.organismNameTextBox.Size = new System.Drawing.Size(259, 23);
            this.organismNameTextBox.TabIndex = 25;
            this.organismNameTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.organismNameTextBox_KeyUp);
            // 
            // addOrganismToPhotoButton
            // 
            this.addOrganismToPhotoButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.addOrganismToPhotoButton.Location = new System.Drawing.Point(1212, 365);
            this.addOrganismToPhotoButton.Name = "addOrganismToPhotoButton";
            this.addOrganismToPhotoButton.Size = new System.Drawing.Size(95, 23);
            this.addOrganismToPhotoButton.TabIndex = 26;
            this.addOrganismToPhotoButton.Text = "Přidat na fotku";
            this.addOrganismToPhotoButton.UseVisualStyleBackColor = true;
            this.addOrganismToPhotoButton.Click += new System.EventHandler(this.addOrganismToPhotoButton_Click);
            // 
            // personNameOrNickTextBox
            // 
            this.personNameOrNickTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.personNameOrNickTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.personNameOrNickTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.personNameOrNickTextBox.Location = new System.Drawing.Point(947, 590);
            this.personNameOrNickTextBox.Name = "personNameOrNickTextBox";
            this.personNameOrNickTextBox.Size = new System.Drawing.Size(259, 23);
            this.personNameOrNickTextBox.TabIndex = 27;
            this.personNameOrNickTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.personNameOrNickTextBox_KeyUp);
            // 
            // addPersonToPhotoButton
            // 
            this.addPersonToPhotoButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.addPersonToPhotoButton.Location = new System.Drawing.Point(1212, 590);
            this.addPersonToPhotoButton.Name = "addPersonToPhotoButton";
            this.addPersonToPhotoButton.Size = new System.Drawing.Size(95, 23);
            this.addPersonToPhotoButton.TabIndex = 28;
            this.addPersonToPhotoButton.Text = "Přidat na fotku";
            this.addPersonToPhotoButton.UseVisualStyleBackColor = true;
            this.addPersonToPhotoButton.Click += new System.EventHandler(this.addPersonToPhotoButton_Click);
            // 
            // personAddButton
            // 
            this.personAddButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.personAddButton.Location = new System.Drawing.Point(1313, 619);
            this.personAddButton.Name = "personAddButton";
            this.personAddButton.Size = new System.Drawing.Size(124, 23);
            this.personAddButton.TabIndex = 29;
            this.personAddButton.Text = "Přidávat lidi";
            this.personAddButton.UseVisualStyleBackColor = true;
            this.personAddButton.Click += new System.EventHandler(this.personAddButton_Click);
            // 
            // AddingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1534, 1041);
            this.Controls.Add(this.personAddButton);
            this.Controls.Add(this.addPersonToPhotoButton);
            this.Controls.Add(this.personNameOrNickTextBox);
            this.Controls.Add(this.addOrganismToPhotoButton);
            this.Controls.Add(this.organismNameTextBox);
            this.Controls.Add(this.personNameOrNickLabel);
            this.Controls.Add(this.organismNameLabel);
            this.Controls.Add(this.removePersonFromPhotoButton);
            this.Controls.Add(this.removeOrganismFromPhotoButton);
            this.Controls.Add(this.peopleOnPhotoListBox);
            this.Controls.Add(this.organismsOnPhotoListBox);
            this.Controls.Add(this.showedPhotoRelativePathTextBox);
            this.Controls.Add(this.showedPhotoRelativePathLabel);
            this.Controls.Add(this.addPhotoToDbButton);
            this.Controls.Add(this.commentTextBox);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.commentLabel);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.showedPhotoDateTextBox);
            this.Controls.Add(this.showedPhotoDateLabel);
            this.Controls.Add(this.showedPhotoPathTextBox);
            this.Controls.Add(this.showedPhotoPathLabel);
            this.Controls.Add(this.selectedImagePictureBox);
            this.Controls.Add(this.imagesListView);
            this.Controls.Add(this.folderChooseLabel);
            this.Controls.Add(this.folderChooseButton);
            this.Controls.Add(this.folderPathTextBox);
            this.Controls.Add(this.organismAddButton);
            this.Name = "AddingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AddingForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddingForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddingForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.selectedImagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button organismAddButton;
        private System.Windows.Forms.TextBox folderPathTextBox;
        private System.Windows.Forms.Button folderChooseButton;
        private System.Windows.Forms.Label folderChooseLabel;
        private System.Windows.Forms.ListView imagesListView;
        private System.Windows.Forms.PictureBox selectedImagePictureBox;
        private System.Windows.Forms.Label showedPhotoPathLabel;
        private System.Windows.Forms.TextBox showedPhotoPathTextBox;
        private System.Windows.Forms.Label showedPhotoDateLabel;
        private System.Windows.Forms.TextBox showedPhotoDateTextBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label commentLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.Button addPhotoToDbButton;
        private System.Windows.Forms.Label showedPhotoRelativePathLabel;
        private System.Windows.Forms.TextBox showedPhotoRelativePathTextBox;
        private System.Windows.Forms.ListBox organismsOnPhotoListBox;
        private System.Windows.Forms.ListBox peopleOnPhotoListBox;
        private System.Windows.Forms.Button removeOrganismFromPhotoButton;
        private System.Windows.Forms.Button removePersonFromPhotoButton;
        private System.Windows.Forms.Label organismNameLabel;
        private System.Windows.Forms.Label personNameOrNickLabel;
        private System.Windows.Forms.TextBox organismNameTextBox;
        private System.Windows.Forms.Button addOrganismToPhotoButton;
        private System.Windows.Forms.TextBox personNameOrNickTextBox;
        private System.Windows.Forms.Button addPersonToPhotoButton;
        private System.Windows.Forms.Button personAddButton;
    }
}