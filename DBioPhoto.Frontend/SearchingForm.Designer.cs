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
            this.labelSearchCategory = new System.Windows.Forms.Label();
            this.labelSearchCzName = new System.Windows.Forms.Label();
            this.labelSearchLatName = new System.Windows.Forms.Label();
            this.labelSearchDateSince = new System.Windows.Forms.Label();
            this.labelSearchBasedOn = new System.Windows.Forms.Label();
            this.labelSearchDateUntil = new System.Windows.Forms.Label();
            this.labelSearchComment = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.textBoxCzName = new System.Windows.Forms.TextBox();
            this.textBoxLatName = new System.Windows.Forms.TextBox();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // labelSearchCategory
            // 
            this.labelSearchCategory.AutoSize = true;
            this.labelSearchCategory.Location = new System.Drawing.Point(46, 65);
            this.labelSearchCategory.Name = "labelSearchCategory";
            this.labelSearchCategory.Size = new System.Drawing.Size(77, 20);
            this.labelSearchCategory.TabIndex = 0;
            this.labelSearchCategory.Text = "Kategorie:";
            // 
            // labelSearchCzName
            // 
            this.labelSearchCzName.AutoSize = true;
            this.labelSearchCzName.Location = new System.Drawing.Point(46, 99);
            this.labelSearchCzName.Name = "labelSearchCzName";
            this.labelSearchCzName.Size = new System.Drawing.Size(112, 20);
            this.labelSearchCzName.TabIndex = 0;
            this.labelSearchCzName.Text = "Českého jména:";
            // 
            // labelSearchLatName
            // 
            this.labelSearchLatName.AutoSize = true;
            this.labelSearchLatName.Location = new System.Drawing.Point(46, 132);
            this.labelSearchLatName.Name = "labelSearchLatName";
            this.labelSearchLatName.Size = new System.Drawing.Size(127, 20);
            this.labelSearchLatName.TabIndex = 0;
            this.labelSearchLatName.Text = "Latinského jména:";
            // 
            // labelSearchDateSince
            // 
            this.labelSearchDateSince.AutoSize = true;
            this.labelSearchDateSince.Location = new System.Drawing.Point(46, 165);
            this.labelSearchDateSince.Name = "labelSearchDateSince";
            this.labelSearchDateSince.Size = new System.Drawing.Size(66, 20);
            this.labelSearchDateSince.TabIndex = 0;
            this.labelSearchDateSince.Text = "Data od:";
            // 
            // labelSearchBasedOn
            // 
            this.labelSearchBasedOn.AutoSize = true;
            this.labelSearchBasedOn.Location = new System.Drawing.Point(46, 31);
            this.labelSearchBasedOn.Name = "labelSearchBasedOn";
            this.labelSearchBasedOn.Size = new System.Drawing.Size(166, 20);
            this.labelSearchBasedOn.TabIndex = 0;
            this.labelSearchBasedOn.Text = "Vyhledávat na základě...";
            // 
            // labelSearchDateUntil
            // 
            this.labelSearchDateUntil.AutoSize = true;
            this.labelSearchDateUntil.Location = new System.Drawing.Point(531, 170);
            this.labelSearchDateUntil.Name = "labelSearchDateUntil";
            this.labelSearchDateUntil.Size = new System.Drawing.Size(30, 20);
            this.labelSearchDateUntil.TabIndex = 0;
            this.labelSearchDateUntil.Text = "do:";
            // 
            // labelSearchComment
            // 
            this.labelSearchComment.AutoSize = true;
            this.labelSearchComment.Location = new System.Drawing.Point(46, 198);
            this.labelSearchComment.Name = "labelSearchComment";
            this.labelSearchComment.Size = new System.Drawing.Size(135, 20);
            this.labelSearchComment.TabIndex = 0;
            this.labelSearchComment.Text = "Ponámky obsahuje:";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "Lidé",
            "Krajina",
            "Rostliny",
            "Zvířata",
            "Houby",
            "Mikroorganismy"});
            this.comboBoxCategory.Location = new System.Drawing.Point(621, 62);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(404, 28);
            this.comboBoxCategory.TabIndex = 1;
            // 
            // textBoxCzName
            // 
            this.textBoxCzName.Location = new System.Drawing.Point(621, 96);
            this.textBoxCzName.Name = "textBoxCzName";
            this.textBoxCzName.Size = new System.Drawing.Size(404, 27);
            this.textBoxCzName.TabIndex = 2;
            // 
            // textBoxLatName
            // 
            this.textBoxLatName.Location = new System.Drawing.Point(621, 129);
            this.textBoxLatName.Name = "textBoxLatName";
            this.textBoxLatName.Size = new System.Drawing.Size(404, 27);
            this.textBoxLatName.TabIndex = 3;
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(621, 198);
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(404, 27);
            this.textBoxComment.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(136, 165);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(372, 27);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(621, 165);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(404, 27);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // SearchingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 774);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.textBoxLatName);
            this.Controls.Add(this.textBoxCzName);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.labelSearchComment);
            this.Controls.Add(this.labelSearchDateUntil);
            this.Controls.Add(this.labelSearchBasedOn);
            this.Controls.Add(this.labelSearchDateSince);
            this.Controls.Add(this.labelSearchLatName);
            this.Controls.Add(this.labelSearchCzName);
            this.Controls.Add(this.labelSearchCategory);
            this.Name = "SearchingForm";
            this.Text = "DBioPhoto - vyhledávání";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label labelSearchCategory;
        private System.Windows.Forms.Label labelSearchCzName;
        private System.Windows.Forms.Label labelSearchLatName;
        private System.Windows.Forms.Label labelSearchDateSince;
        private System.Windows.Forms.Label labelSearchBasedOn;
        private System.Windows.Forms.Label labelSearchDateUntil;
        private System.Windows.Forms.Label labelSearchComment;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.TextBox textBoxCzName;
        private System.Windows.Forms.TextBox textBoxLatName;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}