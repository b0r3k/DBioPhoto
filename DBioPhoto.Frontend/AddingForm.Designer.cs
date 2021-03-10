
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
            ((System.ComponentModel.ISupportInitialize)(this.selectedImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // organismAddButton
            // 
            this.organismAddButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.organismAddButton.Location = new System.Drawing.Point(1370, 50);
            this.organismAddButton.Name = "organismAddButton";
            this.organismAddButton.Size = new System.Drawing.Size(119, 23);
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
            this.imagesListView.HideSelection = false;
            this.imagesListView.Location = new System.Drawing.Point(61, 755);
            this.imagesListView.Name = "imagesListView";
            this.imagesListView.Size = new System.Drawing.Size(906, 187);
            this.imagesListView.TabIndex = 4;
            this.imagesListView.UseCompatibleStateImageBehavior = false;
            // 
            // selectedImagePictureBox
            // 
            this.selectedImagePictureBox.Location = new System.Drawing.Point(61, 221);
            this.selectedImagePictureBox.Name = "selectedImagePictureBox";
            this.selectedImagePictureBox.Size = new System.Drawing.Size(906, 512);
            this.selectedImagePictureBox.TabIndex = 5;
            this.selectedImagePictureBox.TabStop = false;
            // 
            // AddingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1534, 1041);
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
    }
}