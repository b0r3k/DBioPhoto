
namespace DBioPhoto.Frontend
{
    partial class PersonAddForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.nickLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.nickTextBox = new System.Windows.Forms.TextBox();
            this.addToDbButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(46, 59);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 15);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Jméno:";
            // 
            // surnameLabel
            // 
            this.surnameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(46, 96);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(54, 15);
            this.surnameLabel.TabIndex = 1;
            this.surnameLabel.Text = "Příjmení:";
            // 
            // nickLabel
            // 
            this.nickLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nickLabel.AutoSize = true;
            this.nickLabel.Location = new System.Drawing.Point(46, 135);
            this.nickLabel.Name = "nickLabel";
            this.nickLabel.Size = new System.Drawing.Size(60, 15);
            this.nickLabel.TabIndex = 2;
            this.nickLabel.Text = "Přezdívka:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.nameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.nameTextBox.Location = new System.Drawing.Point(139, 56);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(168, 23);
            this.nameTextBox.TabIndex = 3;
            this.nameTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nameTextBox_KeyUp);
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.surnameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.surnameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.surnameTextBox.Location = new System.Drawing.Point(139, 93);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(168, 23);
            this.surnameTextBox.TabIndex = 4;
            this.surnameTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.surnameTextBox_KeyUp);
            // 
            // nickTextBox
            // 
            this.nickTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nickTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.nickTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.nickTextBox.Location = new System.Drawing.Point(139, 132);
            this.nickTextBox.Name = "nickTextBox";
            this.nickTextBox.Size = new System.Drawing.Size(168, 23);
            this.nickTextBox.TabIndex = 5;
            this.nickTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nickTextBox_KeyUp);
            // 
            // addToDbButton
            // 
            this.addToDbButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addToDbButton.Location = new System.Drawing.Point(95, 176);
            this.addToDbButton.Name = "addToDbButton";
            this.addToDbButton.Size = new System.Drawing.Size(145, 23);
            this.addToDbButton.TabIndex = 6;
            this.addToDbButton.Text = "Přidat do databáze";
            this.addToDbButton.UseVisualStyleBackColor = true;
            this.addToDbButton.Click += new System.EventHandler(this.addToDbButton_Click);
            // 
            // PersonAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 271);
            this.Controls.Add(this.addToDbButton);
            this.Controls.Add(this.nickTextBox);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nickLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameLabel);
            this.MinimumSize = new System.Drawing.Size(370, 310);
            this.Name = "PersonAddForm";
            this.Text = "PersonAddForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PersonAddForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label nickLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox nickTextBox;
        private System.Windows.Forms.Button addToDbButton;
    }
}