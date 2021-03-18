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
            this.fromDateLabel = new System.Windows.Forms.Label();
            this.basedOnLabel = new System.Windows.Forms.Label();
            this.untilDateLabel = new System.Windows.Forms.Label();
            this.commentLabel = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.czFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.untilDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.czSecondNameTextBox = new System.Windows.Forms.TextBox();
            this.czSecondNameLabel = new System.Windows.Forms.Label();
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
            this.basedOnComboBox = new System.Windows.Forms.ComboBox();
            this.personNamesGroupBox = new System.Windows.Forms.GroupBox();
            this.latFirstNameLabel = new System.Windows.Forms.Label();
            this.latFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.latSecondNameLabel = new System.Windows.Forms.Label();
            this.latSecondNameTextBox = new System.Windows.Forms.TextBox();
            this.latNamesGroupBox = new System.Windows.Forms.GroupBox();
            this.czNamesGroupBox = new System.Windows.Forms.GroupBox();
            this.showedPhotoPathTextBox = new System.Windows.Forms.TextBox();
            this.showedPhotoPathLabel = new System.Windows.Forms.Label();
            this.copyPathToClipboardButton = new System.Windows.Forms.Button();
            this.organismTypeComboBox = new System.Windows.Forms.ComboBox();
            this.organismColourComboBox = new System.Windows.Forms.ComboBox();
            this.organismTypeLabel = new System.Windows.Forms.Label();
            this.organismColourLabel = new System.Windows.Forms.Label();
            this.typeColourGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.selectedImagePictureBox)).BeginInit();
            this.personNamesGroupBox.SuspendLayout();
            this.latNamesGroupBox.SuspendLayout();
            this.czNamesGroupBox.SuspendLayout();
            this.typeColourGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(423, 12);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(77, 20);
            this.categoryLabel.TabIndex = 0;
            this.categoryLabel.Text = "Kategorie:";
            // 
            // czFirstNameLabel
            // 
            this.czFirstNameLabel.AutoSize = true;
            this.czFirstNameLabel.Location = new System.Drawing.Point(8, 12);
            this.czFirstNameLabel.Name = "czFirstNameLabel";
            this.czFirstNameLabel.Size = new System.Drawing.Size(180, 20);
            this.czFirstNameLabel.TabIndex = 0;
            this.czFirstNameLabel.Text = "Českého rodového jména:";
            // 
            // fromDateLabel
            // 
            this.fromDateLabel.AutoSize = true;
            this.fromDateLabel.Location = new System.Drawing.Point(423, 52);
            this.fromDateLabel.Name = "fromDateLabel";
            this.fromDateLabel.Size = new System.Drawing.Size(66, 20);
            this.fromDateLabel.TabIndex = 0;
            this.fromDateLabel.Text = "Data od:";
            // 
            // basedOnLabel
            // 
            this.basedOnLabel.AutoSize = true;
            this.basedOnLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.basedOnLabel.Location = new System.Drawing.Point(30, 12);
            this.basedOnLabel.Name = "basedOnLabel";
            this.basedOnLabel.Size = new System.Drawing.Size(267, 32);
            this.basedOnLabel.TabIndex = 0;
            this.basedOnLabel.Text = "Vyhledávat na základě...";
            // 
            // untilDateLabel
            // 
            this.untilDateLabel.AutoSize = true;
            this.untilDateLabel.Location = new System.Drawing.Point(909, 49);
            this.untilDateLabel.Name = "untilDateLabel";
            this.untilDateLabel.Size = new System.Drawing.Size(30, 20);
            this.untilDateLabel.TabIndex = 0;
            this.untilDateLabel.Text = "do:";
            // 
            // commentLabel
            // 
            this.commentLabel.AutoSize = true;
            this.commentLabel.Location = new System.Drawing.Point(423, 123);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(143, 20);
            this.commentLabel.TabIndex = 0;
            this.commentLabel.Text = "Poznámka obsahuje:";
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
            this.categoryComboBox.Location = new System.Drawing.Point(963, 8);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(285, 28);
            this.categoryComboBox.TabIndex = 0;
            // 
            // czFirstNameTextBox
            // 
            this.czFirstNameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.czFirstNameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.czFirstNameTextBox.Location = new System.Drawing.Point(259, 8);
            this.czFirstNameTextBox.Name = "czFirstNameTextBox";
            this.czFirstNameTextBox.Size = new System.Drawing.Size(214, 27);
            this.czFirstNameTextBox.TabIndex = 6;
            this.czFirstNameTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.czFirstNameTextBox_KeyUp);
            // 
            // commentTextBox
            // 
            this.commentTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.commentTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.commentTextBox.Location = new System.Drawing.Point(963, 119);
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(285, 27);
            this.commentTextBox.TabIndex = 4;
            this.commentTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.commentTextBox_KeyUp);
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Location = new System.Drawing.Point(557, 44);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(285, 27);
            this.fromDateTimePicker.TabIndex = 1;
            this.fromDateTimePicker.Value = new System.DateTime(2010, 10, 10, 0, 0, 0, 0);
            // 
            // untilDateTimePicker
            // 
            this.untilDateTimePicker.Location = new System.Drawing.Point(963, 44);
            this.untilDateTimePicker.Name = "untilDateTimePicker";
            this.untilDateTimePicker.Size = new System.Drawing.Size(285, 27);
            this.untilDateTimePicker.TabIndex = 2;
            // 
            // czSecondNameTextBox
            // 
            this.czSecondNameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.czSecondNameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.czSecondNameTextBox.Location = new System.Drawing.Point(259, 45);
            this.czSecondNameTextBox.Name = "czSecondNameTextBox";
            this.czSecondNameTextBox.Size = new System.Drawing.Size(214, 27);
            this.czSecondNameTextBox.TabIndex = 7;
            this.czSecondNameTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.czSecondNameTextBox_KeyUp);
            // 
            // czSecondNameLabel
            // 
            this.czSecondNameLabel.AutoSize = true;
            this.czSecondNameLabel.Location = new System.Drawing.Point(8, 49);
            this.czSecondNameLabel.Name = "czSecondNameLabel";
            this.czSecondNameLabel.Size = new System.Drawing.Size(187, 20);
            this.czSecondNameLabel.TabIndex = 8;
            this.czSecondNameLabel.Text = "Českého druhového jména:";
            // 
            // personSurnameTextBox
            // 
            this.personSurnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.personSurnameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.personSurnameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.personSurnameTextBox.Location = new System.Drawing.Point(256, 53);
            this.personSurnameTextBox.Name = "personSurnameTextBox";
            this.personSurnameTextBox.Size = new System.Drawing.Size(285, 27);
            this.personSurnameTextBox.TabIndex = 7;
            this.personSurnameTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.personSurnameTextBox_KeyUp);
            // 
            // personNickTextBox
            // 
            this.personNickTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.personNickTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.personNickTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.personNickTextBox.Location = new System.Drawing.Point(256, 89);
            this.personNickTextBox.Name = "personNickTextBox";
            this.personNickTextBox.Size = new System.Drawing.Size(285, 27);
            this.personNickTextBox.TabIndex = 8;
            this.personNickTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.personNickTextBox_KeyUp);
            // 
            // personNameTextBox
            // 
            this.personNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.personNameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.personNameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.personNameTextBox.Location = new System.Drawing.Point(256, 17);
            this.personNameTextBox.Name = "personNameTextBox";
            this.personNameTextBox.Size = new System.Drawing.Size(285, 27);
            this.personNameTextBox.TabIndex = 6;
            this.personNameTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.personNameTextBox_KeyUp);
            // 
            // personSurnameLabel
            // 
            this.personSurnameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.personSurnameLabel.AutoSize = true;
            this.personSurnameLabel.Location = new System.Drawing.Point(33, 59);
            this.personSurnameLabel.Name = "personSurnameLabel";
            this.personSurnameLabel.Size = new System.Drawing.Size(110, 20);
            this.personSurnameLabel.TabIndex = 16;
            this.personSurnameLabel.Text = "Příjmení osoby:";
            // 
            // personNickLabel
            // 
            this.personNickLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.personNickLabel.AutoSize = true;
            this.personNickLabel.Location = new System.Drawing.Point(33, 95);
            this.personNickLabel.Name = "personNickLabel";
            this.personNickLabel.Size = new System.Drawing.Size(119, 20);
            this.personNickLabel.TabIndex = 14;
            this.personNickLabel.Text = "Přezdívka osoby:";
            // 
            // personNameLabel
            // 
            this.personNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.personNameLabel.AutoSize = true;
            this.personNameLabel.Location = new System.Drawing.Point(33, 21);
            this.personNameLabel.Name = "personNameLabel";
            this.personNameLabel.Size = new System.Drawing.Size(98, 20);
            this.personNameLabel.TabIndex = 15;
            this.personNameLabel.Text = "Jména osoby:";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(423, 85);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(48, 20);
            this.locationLabel.TabIndex = 17;
            this.locationLabel.Text = "Místa:";
            // 
            // locationTextBox
            // 
            this.locationTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.locationTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.locationTextBox.Location = new System.Drawing.Point(963, 81);
            this.locationTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(285, 27);
            this.locationTextBox.TabIndex = 3;
            this.locationTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.locationTextBox_KeyUp);
            // 
            // selectedImagePictureBox
            // 
            this.selectedImagePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedImagePictureBox.Location = new System.Drawing.Point(848, 414);
            this.selectedImagePictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.selectedImagePictureBox.Name = "selectedImagePictureBox";
            this.selectedImagePictureBox.Size = new System.Drawing.Size(1042, 628);
            this.selectedImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.selectedImagePictureBox.TabIndex = 19;
            this.selectedImagePictureBox.TabStop = false;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchButton.Location = new System.Drawing.Point(582, 355);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(222, 51);
            this.searchButton.TabIndex = 9;
            this.searchButton.Text = "Hledat";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // imagesListView
            // 
            this.imagesListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.imagesListView.HideSelection = false;
            this.imagesListView.Location = new System.Drawing.Point(17, 414);
            this.imagesListView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imagesListView.MultiSelect = false;
            this.imagesListView.Name = "imagesListView";
            this.imagesListView.Size = new System.Drawing.Size(813, 612);
            this.imagesListView.TabIndex = 10;
            this.imagesListView.UseCompatibleStateImageBehavior = false;
            this.imagesListView.SelectedIndexChanged += new System.EventHandler(this.imagesListView_SelectedIndexChanged);
            // 
            // basedOnComboBox
            // 
            this.basedOnComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.basedOnComboBox.FormattingEnabled = true;
            this.basedOnComboBox.Location = new System.Drawing.Point(775, 157);
            this.basedOnComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.basedOnComboBox.Name = "basedOnComboBox";
            this.basedOnComboBox.Size = new System.Drawing.Size(197, 28);
            this.basedOnComboBox.TabIndex = 5;
            this.basedOnComboBox.SelectedIndexChanged += new System.EventHandler(this.basedOnComboBox_SelectedIndexChanged);
            // 
            // personNamesGroupBox
            // 
            this.personNamesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.personNamesGroupBox.Controls.Add(this.personSurnameLabel);
            this.personNamesGroupBox.Controls.Add(this.personNickLabel);
            this.personNamesGroupBox.Controls.Add(this.personNameLabel);
            this.personNamesGroupBox.Controls.Add(this.personSurnameTextBox);
            this.personNamesGroupBox.Controls.Add(this.personNickTextBox);
            this.personNamesGroupBox.Controls.Add(this.personNameTextBox);
            this.personNamesGroupBox.Location = new System.Drawing.Point(963, 213);
            this.personNamesGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.personNamesGroupBox.Name = "personNamesGroupBox";
            this.personNamesGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.personNamesGroupBox.Size = new System.Drawing.Size(544, 135);
            this.personNamesGroupBox.TabIndex = 25;
            this.personNamesGroupBox.TabStop = false;
            // 
            // latFirstNameLabel
            // 
            this.latFirstNameLabel.AutoSize = true;
            this.latFirstNameLabel.Location = new System.Drawing.Point(5, 8);
            this.latFirstNameLabel.Name = "latFirstNameLabel";
            this.latFirstNameLabel.Size = new System.Drawing.Size(195, 20);
            this.latFirstNameLabel.TabIndex = 0;
            this.latFirstNameLabel.Text = "Latinského rodového jména:";
            // 
            // latFirstNameTextBox
            // 
            this.latFirstNameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.latFirstNameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.latFirstNameTextBox.Location = new System.Drawing.Point(259, 4);
            this.latFirstNameTextBox.Name = "latFirstNameTextBox";
            this.latFirstNameTextBox.Size = new System.Drawing.Size(214, 27);
            this.latFirstNameTextBox.TabIndex = 6;
            this.latFirstNameTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.latFirstNameTextBox_KeyUp);
            // 
            // latSecondNameLabel
            // 
            this.latSecondNameLabel.AutoSize = true;
            this.latSecondNameLabel.Location = new System.Drawing.Point(5, 44);
            this.latSecondNameLabel.Name = "latSecondNameLabel";
            this.latSecondNameLabel.Size = new System.Drawing.Size(202, 20);
            this.latSecondNameLabel.TabIndex = 9;
            this.latSecondNameLabel.Text = "Latinského druhového jména:";
            // 
            // latSecondNameTextBox
            // 
            this.latSecondNameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.latSecondNameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.latSecondNameTextBox.Location = new System.Drawing.Point(259, 40);
            this.latSecondNameTextBox.Name = "latSecondNameTextBox";
            this.latSecondNameTextBox.Size = new System.Drawing.Size(214, 27);
            this.latSecondNameTextBox.TabIndex = 7;
            this.latSecondNameTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.latSecondNameTextBox_KeyUp);
            // 
            // latNamesGroupBox
            // 
            this.latNamesGroupBox.Controls.Add(this.latSecondNameTextBox);
            this.latNamesGroupBox.Controls.Add(this.latSecondNameLabel);
            this.latNamesGroupBox.Controls.Add(this.latFirstNameTextBox);
            this.latNamesGroupBox.Controls.Add(this.latFirstNameLabel);
            this.latNamesGroupBox.Location = new System.Drawing.Point(17, 269);
            this.latNamesGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.latNamesGroupBox.Name = "latNamesGroupBox";
            this.latNamesGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.latNamesGroupBox.Size = new System.Drawing.Size(737, 79);
            this.latNamesGroupBox.TabIndex = 26;
            this.latNamesGroupBox.TabStop = false;
            // 
            // czNamesGroupBox
            // 
            this.czNamesGroupBox.Controls.Add(this.czSecondNameLabel);
            this.czNamesGroupBox.Controls.Add(this.czSecondNameTextBox);
            this.czNamesGroupBox.Controls.Add(this.czFirstNameTextBox);
            this.czNamesGroupBox.Controls.Add(this.czFirstNameLabel);
            this.czNamesGroupBox.Location = new System.Drawing.Point(17, 187);
            this.czNamesGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.czNamesGroupBox.Name = "czNamesGroupBox";
            this.czNamesGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.czNamesGroupBox.Size = new System.Drawing.Size(739, 80);
            this.czNamesGroupBox.TabIndex = 27;
            this.czNamesGroupBox.TabStop = false;
            // 
            // showedPhotoPathTextBox
            // 
            this.showedPhotoPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showedPhotoPathTextBox.Location = new System.Drawing.Point(1007, 377);
            this.showedPhotoPathTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.showedPhotoPathTextBox.Name = "showedPhotoPathTextBox";
            this.showedPhotoPathTextBox.ReadOnly = true;
            this.showedPhotoPathTextBox.Size = new System.Drawing.Size(739, 27);
            this.showedPhotoPathTextBox.TabIndex = 28;
            // 
            // showedPhotoPathLabel
            // 
            this.showedPhotoPathLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showedPhotoPathLabel.AutoSize = true;
            this.showedPhotoPathLabel.Location = new System.Drawing.Point(848, 380);
            this.showedPhotoPathLabel.Name = "showedPhotoPathLabel";
            this.showedPhotoPathLabel.Size = new System.Drawing.Size(153, 20);
            this.showedPhotoPathLabel.TabIndex = 29;
            this.showedPhotoPathLabel.Text = "Cesta k vybrané fotce:";
            // 
            // copyPathToClipboardButton
            // 
            this.copyPathToClipboardButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.copyPathToClipboardButton.Location = new System.Drawing.Point(1752, 375);
            this.copyPathToClipboardButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.copyPathToClipboardButton.Name = "copyPathToClipboardButton";
            this.copyPathToClipboardButton.Size = new System.Drawing.Size(151, 31);
            this.copyPathToClipboardButton.TabIndex = 11;
            this.copyPathToClipboardButton.Text = "Kopírovat cestu";
            this.copyPathToClipboardButton.UseVisualStyleBackColor = true;
            this.copyPathToClipboardButton.Click += new System.EventHandler(this.copyPathToClipboardButton_Click);
            // 
            // organismTypeComboBox
            // 
            this.organismTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.organismTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.organismTypeComboBox.FormattingEnabled = true;
            this.organismTypeComboBox.Location = new System.Drawing.Point(182, 3);
            this.organismTypeComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.organismTypeComboBox.Name = "organismTypeComboBox";
            this.organismTypeComboBox.Size = new System.Drawing.Size(285, 28);
            this.organismTypeComboBox.TabIndex = 6;
            // 
            // organismColourComboBox
            // 
            this.organismColourComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.organismColourComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.organismColourComboBox.FormattingEnabled = true;
            this.organismColourComboBox.Location = new System.Drawing.Point(182, 41);
            this.organismColourComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.organismColourComboBox.Name = "organismColourComboBox";
            this.organismColourComboBox.Size = new System.Drawing.Size(285, 28);
            this.organismColourComboBox.TabIndex = 7;
            // 
            // organismTypeLabel
            // 
            this.organismTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.organismTypeLabel.AutoSize = true;
            this.organismTypeLabel.Location = new System.Drawing.Point(1, 9);
            this.organismTypeLabel.Name = "organismTypeLabel";
            this.organismTypeLabel.Size = new System.Drawing.Size(118, 20);
            this.organismTypeLabel.TabIndex = 33;
            this.organismTypeLabel.Text = "Druh organismu:";
            // 
            // organismColourLabel
            // 
            this.organismColourLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.organismColourLabel.AutoSize = true;
            this.organismColourLabel.Location = new System.Drawing.Point(1, 45);
            this.organismColourLabel.Name = "organismColourLabel";
            this.organismColourLabel.Size = new System.Drawing.Size(123, 20);
            this.organismColourLabel.TabIndex = 34;
            this.organismColourLabel.Text = "Barva organismu:";
            // 
            // typeColourGroupBox
            // 
            this.typeColourGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.typeColourGroupBox.Controls.Add(this.organismColourLabel);
            this.typeColourGroupBox.Controls.Add(this.organismTypeLabel);
            this.typeColourGroupBox.Controls.Add(this.organismColourComboBox);
            this.typeColourGroupBox.Controls.Add(this.organismTypeComboBox);
            this.typeColourGroupBox.Location = new System.Drawing.Point(1412, 249);
            this.typeColourGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.typeColourGroupBox.Name = "typeColourGroupBox";
            this.typeColourGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.typeColourGroupBox.Size = new System.Drawing.Size(478, 77);
            this.typeColourGroupBox.TabIndex = 35;
            this.typeColourGroupBox.TabStop = false;
            this.typeColourGroupBox.Enter += new System.EventHandler(this.typeColourGroupBox_Enter);
            // 
            // SearchingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.typeColourGroupBox);
            this.Controls.Add(this.copyPathToClipboardButton);
            this.Controls.Add(this.showedPhotoPathLabel);
            this.Controls.Add(this.showedPhotoPathTextBox);
            this.Controls.Add(this.czNamesGroupBox);
            this.Controls.Add(this.latNamesGroupBox);
            this.Controls.Add(this.personNamesGroupBox);
            this.Controls.Add(this.basedOnComboBox);
            this.Controls.Add(this.imagesListView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.selectedImagePictureBox);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.untilDateTimePicker);
            this.Controls.Add(this.fromDateTimePicker);
            this.Controls.Add(this.commentTextBox);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.commentLabel);
            this.Controls.Add(this.untilDateLabel);
            this.Controls.Add(this.basedOnLabel);
            this.Controls.Add(this.fromDateLabel);
            this.Controls.Add(this.categoryLabel);
            this.MinimumSize = new System.Drawing.Size(1918, 651);
            this.Name = "SearchingForm";
            this.Text = "DBioPhoto - vyhledávání";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchingForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchingForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.selectedImagePictureBox)).EndInit();
            this.personNamesGroupBox.ResumeLayout(false);
            this.personNamesGroupBox.PerformLayout();
            this.latNamesGroupBox.ResumeLayout(false);
            this.latNamesGroupBox.PerformLayout();
            this.czNamesGroupBox.ResumeLayout(false);
            this.czNamesGroupBox.PerformLayout();
            this.typeColourGroupBox.ResumeLayout(false);
            this.typeColourGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label czFirstNameLabel;
        private System.Windows.Forms.Label fromDateLabel;
        private System.Windows.Forms.Label basedOnLabel;
        private System.Windows.Forms.Label untilDateLabel;
        private System.Windows.Forms.Label commentLabel;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.TextBox czFirstNameTextBox;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.DateTimePicker untilDateTimePicker;
        private System.Windows.Forms.TextBox czSecondNameTextBox;
        private System.Windows.Forms.Label czSecondNameLabel;
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
        private System.Windows.Forms.ComboBox basedOnComboBox;
        private System.Windows.Forms.GroupBox personNamesGroupBox;
        private System.Windows.Forms.Label latFirstNameLabel;
        private System.Windows.Forms.TextBox latFirstNameTextBox;
        private System.Windows.Forms.Label latSecondNameLabel;
        private System.Windows.Forms.TextBox latSecondNameTextBox;
        private System.Windows.Forms.GroupBox latNamesGroupBox;
        private System.Windows.Forms.GroupBox czNamesGroupBox;
        private System.Windows.Forms.TextBox showedPhotoPathTextBox;
        private System.Windows.Forms.Label showedPhotoPathLabel;
        private System.Windows.Forms.Button copyPathToClipboardButton;
        private System.Windows.Forms.ComboBox organismTypeComboBox;
        private System.Windows.Forms.ComboBox organismColourComboBox;
        private System.Windows.Forms.Label organismTypeLabel;
        private System.Windows.Forms.Label organismColourLabel;
        private System.Windows.Forms.GroupBox typeColourGroupBox;
    }
}