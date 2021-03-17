namespace DBioPhoto.Frontend
{
    partial class SearchingForm
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
            this.categoryLabel = new System.Windows.Forms.Label();
            this.czFirstNameLabel = new System.Windows.Forms.Label();
            this.latFirstNameLabel = new System.Windows.Forms.Label();
            this.fromDateLabel = new System.Windows.Forms.Label();
            this.basedOnLabel = new System.Windows.Forms.Label();
            this.untilDateLabel = new System.Windows.Forms.Label();
            this.commentLabel = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.czFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.latFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.untilDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.czSecondNameTextBox = new System.Windows.Forms.TextBox();
            this.czSecondNameLabel = new System.Windows.Forms.Label();
            this.latSecondNameLabel = new System.Windows.Forms.Label();
            this.latSecondNameTextBox = new System.Windows.Forms.TextBox();
            this.personSurnameTextBox = new System.Windows.Forms.TextBox();
            this.personNickTextBox = new System.Windows.Forms.TextBox();
            this.personNameTextBox = new System.Windows.Forms.TextBox();
            this.personSurnameLabel = new System.Windows.Forms.Label();
            this.personNickLabel = new System.Windows.Forms.Label();
            this.personNameLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.selectedImagePictureBox = new System.Windows.Forms.PictureBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.imagesListView = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.selectedImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(513, 24);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(60, 15);
            this.categoryLabel.TabIndex = 0;
            this.categoryLabel.Text = "Kategorie:";
            // 
            // czFirstNameLabel
            // 
            this.czFirstNameLabel.AutoSize = true;
            this.czFirstNameLabel.Location = new System.Drawing.Point(187, 154);
            this.czFirstNameLabel.Name = "czFirstNameLabel";
            this.czFirstNameLabel.Size = new System.Drawing.Size(145, 15);
            this.czFirstNameLabel.TabIndex = 0;
            this.czFirstNameLabel.Text = "Českého rodového jména:";
            // 
            // latFirstNameLabel
            // 
            this.latFirstNameLabel.AutoSize = true;
            this.latFirstNameLabel.Location = new System.Drawing.Point(187, 209);
            this.latFirstNameLabel.Name = "latFirstNameLabel";
            this.latFirstNameLabel.Size = new System.Drawing.Size(157, 15);
            this.latFirstNameLabel.TabIndex = 0;
            this.latFirstNameLabel.Text = "Latinského rodového jména:";
            // 
            // fromDateLabel
            // 
            this.fromDateLabel.AutoSize = true;
            this.fromDateLabel.Location = new System.Drawing.Point(513, 54);
            this.fromDateLabel.Name = "fromDateLabel";
            this.fromDateLabel.Size = new System.Drawing.Size(51, 15);
            this.fromDateLabel.TabIndex = 0;
            this.fromDateLabel.Text = "Data od:";
            // 
            // basedOnLabel
            // 
            this.basedOnLabel.AutoSize = true;
            this.basedOnLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.basedOnLabel.Location = new System.Drawing.Point(30, 14);
            this.basedOnLabel.Name = "basedOnLabel";
            this.basedOnLabel.Size = new System.Drawing.Size(212, 25);
            this.basedOnLabel.TabIndex = 0;
            this.basedOnLabel.Text = "Vyhledávat na základě...";
            // 
            // untilDateLabel
            // 
            this.untilDateLabel.AutoSize = true;
            this.untilDateLabel.Location = new System.Drawing.Point(938, 52);
            this.untilDateLabel.Name = "untilDateLabel";
            this.untilDateLabel.Size = new System.Drawing.Size(24, 15);
            this.untilDateLabel.TabIndex = 0;
            this.untilDateLabel.Text = "do:";
            // 
            // commentLabel
            // 
            this.commentLabel.AutoSize = true;
            this.commentLabel.Location = new System.Drawing.Point(513, 107);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(111, 15);
            this.commentLabel.TabIndex = 0;
            this.commentLabel.Text = "Ponámka obsahuje:";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "Lidé",
            "Krajina",
            "Rostliny",
            "Zvířata",
            "Houby",
            "Mikroorganismy"});
            this.categoryComboBox.Location = new System.Drawing.Point(986, 21);
            this.categoryComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(250, 23);
            this.categoryComboBox.TabIndex = 1;
            // 
            // czFirstNameTextBox
            // 
            this.czFirstNameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.czFirstNameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.czFirstNameTextBox.Location = new System.Drawing.Point(660, 152);
            this.czFirstNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.czFirstNameTextBox.Name = "czFirstNameTextBox";
            this.czFirstNameTextBox.Size = new System.Drawing.Size(250, 23);
            this.czFirstNameTextBox.TabIndex = 2;
            // 
            // latFirstNameTextBox
            // 
            this.latFirstNameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.latFirstNameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.latFirstNameTextBox.Location = new System.Drawing.Point(660, 206);
            this.latFirstNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.latFirstNameTextBox.Name = "latFirstNameTextBox";
            this.latFirstNameTextBox.Size = new System.Drawing.Size(250, 23);
            this.latFirstNameTextBox.TabIndex = 3;
            // 
            // commentTextBox
            // 
            this.commentTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.commentTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.commentTextBox.Location = new System.Drawing.Point(986, 104);
            this.commentTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(250, 23);
            this.commentTextBox.TabIndex = 4;
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Location = new System.Drawing.Point(630, 48);
            this.fromDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(250, 23);
            this.fromDateTimePicker.TabIndex = 5;
            this.fromDateTimePicker.Value = new System.DateTime(2010, 10, 10, 0, 0, 0, 0);
            // 
            // untilDateTimePicker
            // 
            this.untilDateTimePicker.Location = new System.Drawing.Point(986, 48);
            this.untilDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.untilDateTimePicker.Name = "untilDateTimePicker";
            this.untilDateTimePicker.Size = new System.Drawing.Size(250, 23);
            this.untilDateTimePicker.TabIndex = 6;
            // 
            // czSecondNameTextBox
            // 
            this.czSecondNameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.czSecondNameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.czSecondNameTextBox.Location = new System.Drawing.Point(660, 179);
            this.czSecondNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.czSecondNameTextBox.Name = "czSecondNameTextBox";
            this.czSecondNameTextBox.Size = new System.Drawing.Size(250, 23);
            this.czSecondNameTextBox.TabIndex = 7;
            // 
            // czSecondNameLabel
            // 
            this.czSecondNameLabel.AutoSize = true;
            this.czSecondNameLabel.Location = new System.Drawing.Point(187, 182);
            this.czSecondNameLabel.Name = "czSecondNameLabel";
            this.czSecondNameLabel.Size = new System.Drawing.Size(152, 15);
            this.czSecondNameLabel.TabIndex = 8;
            this.czSecondNameLabel.Text = "Českého druhového jména:";
            // 
            // latSecondNameLabel
            // 
            this.latSecondNameLabel.AutoSize = true;
            this.latSecondNameLabel.Location = new System.Drawing.Point(187, 236);
            this.latSecondNameLabel.Name = "latSecondNameLabel";
            this.latSecondNameLabel.Size = new System.Drawing.Size(164, 15);
            this.latSecondNameLabel.TabIndex = 9;
            this.latSecondNameLabel.Text = "Latinského druhového jména:";
            // 
            // latSecondNameTextBox
            // 
            this.latSecondNameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.latSecondNameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.latSecondNameTextBox.Location = new System.Drawing.Point(660, 233);
            this.latSecondNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.latSecondNameTextBox.Name = "latSecondNameTextBox";
            this.latSecondNameTextBox.Size = new System.Drawing.Size(250, 23);
            this.latSecondNameTextBox.TabIndex = 10;
            // 
            // personSurnameTextBox
            // 
            this.personSurnameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.personSurnameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.personSurnameTextBox.Location = new System.Drawing.Point(1332, 201);
            this.personSurnameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.personSurnameTextBox.Name = "personSurnameTextBox";
            this.personSurnameTextBox.Size = new System.Drawing.Size(250, 23);
            this.personSurnameTextBox.TabIndex = 13;
            // 
            // personNickTextBox
            // 
            this.personNickTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.personNickTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.personNickTextBox.Location = new System.Drawing.Point(1332, 228);
            this.personNickTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.personNickTextBox.Name = "personNickTextBox";
            this.personNickTextBox.Size = new System.Drawing.Size(250, 23);
            this.personNickTextBox.TabIndex = 12;
            // 
            // personNameTextBox
            // 
            this.personNameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.personNameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.personNameTextBox.Location = new System.Drawing.Point(1332, 174);
            this.personNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.personNameTextBox.Name = "personNameTextBox";
            this.personNameTextBox.Size = new System.Drawing.Size(250, 23);
            this.personNameTextBox.TabIndex = 11;
            // 
            // personSurnameLabel
            // 
            this.personSurnameLabel.AutoSize = true;
            this.personSurnameLabel.Location = new System.Drawing.Point(1137, 205);
            this.personSurnameLabel.Name = "personSurnameLabel";
            this.personSurnameLabel.Size = new System.Drawing.Size(89, 15);
            this.personSurnameLabel.TabIndex = 16;
            this.personSurnameLabel.Text = "Příjmení osoby:";
            // 
            // personNickLabel
            // 
            this.personNickLabel.AutoSize = true;
            this.personNickLabel.Location = new System.Drawing.Point(1137, 232);
            this.personNickLabel.Name = "personNickLabel";
            this.personNickLabel.Size = new System.Drawing.Size(95, 15);
            this.personNickLabel.TabIndex = 14;
            this.personNickLabel.Text = "Přezdívky osoby:";
            // 
            // personNameLabel
            // 
            this.personNameLabel.AutoSize = true;
            this.personNameLabel.Location = new System.Drawing.Point(1137, 177);
            this.personNameLabel.Name = "personNameLabel";
            this.personNameLabel.Size = new System.Drawing.Size(79, 15);
            this.personNameLabel.TabIndex = 15;
            this.personNameLabel.Text = "Jména osoby:";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(513, 79);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(39, 15);
            this.locationLabel.TabIndex = 17;
            this.locationLabel.Text = "Místa:";
            // 
            // locationTextBox
            // 
            this.locationTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.locationTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.locationTextBox.Location = new System.Drawing.Point(986, 76);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(250, 23);
            this.locationTextBox.TabIndex = 18;
            // 
            // selectedImagePictureBox
            // 
            this.selectedImagePictureBox.Location = new System.Drawing.Point(959, 335);
            this.selectedImagePictureBox.Name = "selectedImagePictureBox";
            this.selectedImagePictureBox.Size = new System.Drawing.Size(900, 675);
            this.selectedImagePictureBox.TabIndex = 19;
            this.selectedImagePictureBox.TabStop = false;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchButton.Location = new System.Drawing.Point(513, 270);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(194, 45);
            this.searchButton.TabIndex = 20;
            this.searchButton.Text = "Hledat";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // imagesListView
            // 
            this.imagesListView.HideSelection = false;
            this.imagesListView.Location = new System.Drawing.Point(30, 335);
            this.imagesListView.Name = "imagesListView";
            this.imagesListView.Size = new System.Drawing.Size(900, 675);
            this.imagesListView.TabIndex = 21;
            this.imagesListView.UseCompatibleStateImageBehavior = false;
            // 
            // SearchingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.imagesListView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.selectedImagePictureBox);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.personSurnameLabel);
            this.Controls.Add(this.personNickLabel);
            this.Controls.Add(this.personNameLabel);
            this.Controls.Add(this.personSurnameTextBox);
            this.Controls.Add(this.personNickTextBox);
            this.Controls.Add(this.personNameTextBox);
            this.Controls.Add(this.latSecondNameTextBox);
            this.Controls.Add(this.latSecondNameLabel);
            this.Controls.Add(this.czSecondNameLabel);
            this.Controls.Add(this.czSecondNameTextBox);
            this.Controls.Add(this.untilDateTimePicker);
            this.Controls.Add(this.fromDateTimePicker);
            this.Controls.Add(this.commentTextBox);
            this.Controls.Add(this.latFirstNameTextBox);
            this.Controls.Add(this.czFirstNameTextBox);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.commentLabel);
            this.Controls.Add(this.untilDateLabel);
            this.Controls.Add(this.basedOnLabel);
            this.Controls.Add(this.fromDateLabel);
            this.Controls.Add(this.latFirstNameLabel);
            this.Controls.Add(this.czFirstNameLabel);
            this.Controls.Add(this.categoryLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SearchingForm";
            this.Text = "DBioPhoto - vyhledávání";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchingForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchingForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.selectedImagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label czFirstNameLabel;
        private System.Windows.Forms.Label latFirstNameLabel;
        private System.Windows.Forms.Label fromDateLabel;
        private System.Windows.Forms.Label basedOnLabel;
        private System.Windows.Forms.Label untilDateLabel;
        private System.Windows.Forms.Label commentLabel;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.TextBox czFirstNameTextBox;
        private System.Windows.Forms.TextBox latFirstNameTextBox;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.DateTimePicker untilDateTimePicker;
        private System.Windows.Forms.TextBox czSecondNameTextBox;
        private System.Windows.Forms.Label czSecondNameLabel;
        private System.Windows.Forms.Label latSecondNameLabel;
        private System.Windows.Forms.TextBox latSecondNameTextBox;
        private System.Windows.Forms.TextBox personSurnameTextBox;
        private System.Windows.Forms.TextBox personNickTextBox;
        private System.Windows.Forms.TextBox personNameTextBox;
        private System.Windows.Forms.Label personSurnameLabel;
        private System.Windows.Forms.Label personNickLabel;
        private System.Windows.Forms.Label personNameLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.PictureBox selectedImagePictureBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListView imagesListView;
    }
}