namespace BookShopDb.View
{
    partial class NewBook
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
            this.cancelBookButton = new System.Windows.Forms.Button();
            this.addBookButton = new System.Windows.Forms.Button();
            this.priceBookTextBox = new System.Windows.Forms.TextBox();
            this.releaseBookDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.authorBookTextBox = new System.Windows.Forms.TextBox();
            this.titleBookTextBox = new System.Windows.Forms.TextBox();
            this.pageNumberBookLabel = new System.Windows.Forms.Label();
            this.priceBookLabel = new System.Windows.Forms.Label();
            this.categoryBookLabel = new System.Windows.Forms.Label();
            this.releaseBookDateLabel = new System.Windows.Forms.Label();
            this.authorBookLabel = new System.Windows.Forms.Label();
            this.genreBookLabel = new System.Windows.Forms.Label();
            this.titleBookLabel = new System.Windows.Forms.Label();
            this.categoriacomboBox1 = new System.Windows.Forms.ComboBox();
            this.mufajcomboBox1 = new System.Windows.Forms.ComboBox();
            this.pageNumbernumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pageNumbernumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelBookButton
            // 
            this.cancelBookButton.Location = new System.Drawing.Point(157, 224);
            this.cancelBookButton.Name = "cancelBookButton";
            this.cancelBookButton.Size = new System.Drawing.Size(75, 23);
            this.cancelBookButton.TabIndex = 34;
            this.cancelBookButton.Text = "&Mégse";
            this.cancelBookButton.UseVisualStyleBackColor = true;
            this.cancelBookButton.Click += new System.EventHandler(this.cancelBookButton_Click);
            // 
            // addBookButton
            // 
            this.addBookButton.Location = new System.Drawing.Point(51, 224);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(75, 23);
            this.addBookButton.TabIndex = 33;
            this.addBookButton.Text = "&Hozzáadás";
            this.addBookButton.UseVisualStyleBackColor = true;
            this.addBookButton.Click += new System.EventHandler(this.addBookButton_Click);
            // 
            // priceBookTextBox
            // 
            this.priceBookTextBox.Location = new System.Drawing.Point(146, 171);
            this.priceBookTextBox.Name = "priceBookTextBox";
            this.priceBookTextBox.Size = new System.Drawing.Size(128, 20);
            this.priceBookTextBox.TabIndex = 32;
            // 
            // releaseBookDateTimePicker
            // 
            this.releaseBookDateTimePicker.Location = new System.Drawing.Point(146, 93);
            this.releaseBookDateTimePicker.Name = "releaseBookDateTimePicker";
            this.releaseBookDateTimePicker.Size = new System.Drawing.Size(128, 20);
            this.releaseBookDateTimePicker.TabIndex = 28;
            // 
            // authorBookTextBox
            // 
            this.authorBookTextBox.Location = new System.Drawing.Point(146, 41);
            this.authorBookTextBox.Name = "authorBookTextBox";
            this.authorBookTextBox.Size = new System.Drawing.Size(128, 20);
            this.authorBookTextBox.TabIndex = 27;
            // 
            // titleBookTextBox
            // 
            this.titleBookTextBox.Location = new System.Drawing.Point(146, 14);
            this.titleBookTextBox.Name = "titleBookTextBox";
            this.titleBookTextBox.Size = new System.Drawing.Size(128, 20);
            this.titleBookTextBox.TabIndex = 26;
            // 
            // pageNumberBookLabel
            // 
            this.pageNumberBookLabel.AutoSize = true;
            this.pageNumberBookLabel.Location = new System.Drawing.Point(11, 148);
            this.pageNumberBookLabel.Name = "pageNumberBookLabel";
            this.pageNumberBookLabel.Size = new System.Drawing.Size(58, 13);
            this.pageNumberBookLabel.TabIndex = 25;
            this.pageNumberBookLabel.Text = "Oldalszám:";
            // 
            // priceBookLabel
            // 
            this.priceBookLabel.AutoSize = true;
            this.priceBookLabel.Location = new System.Drawing.Point(11, 174);
            this.priceBookLabel.Name = "priceBookLabel";
            this.priceBookLabel.Size = new System.Drawing.Size(20, 13);
            this.priceBookLabel.TabIndex = 24;
            this.priceBookLabel.Text = "Ár:";
            // 
            // categoryBookLabel
            // 
            this.categoryBookLabel.AutoSize = true;
            this.categoryBookLabel.Location = new System.Drawing.Point(11, 122);
            this.categoryBookLabel.Name = "categoryBookLabel";
            this.categoryBookLabel.Size = new System.Drawing.Size(55, 13);
            this.categoryBookLabel.TabIndex = 23;
            this.categoryBookLabel.Text = "Kategória:";
            // 
            // releaseBookDateLabel
            // 
            this.releaseBookDateLabel.AutoSize = true;
            this.releaseBookDateLabel.Location = new System.Drawing.Point(11, 99);
            this.releaseBookDateLabel.Name = "releaseBookDateLabel";
            this.releaseBookDateLabel.Size = new System.Drawing.Size(76, 13);
            this.releaseBookDateLabel.TabIndex = 22;
            this.releaseBookDateLabel.Text = "Kiadási dátum:";
            // 
            // authorBookLabel
            // 
            this.authorBookLabel.AutoSize = true;
            this.authorBookLabel.Location = new System.Drawing.Point(11, 44);
            this.authorBookLabel.Name = "authorBookLabel";
            this.authorBookLabel.Size = new System.Drawing.Size(42, 13);
            this.authorBookLabel.TabIndex = 21;
            this.authorBookLabel.Text = "Szerző:";
            // 
            // genreBookLabel
            // 
            this.genreBookLabel.AutoSize = true;
            this.genreBookLabel.Location = new System.Drawing.Point(11, 70);
            this.genreBookLabel.Name = "genreBookLabel";
            this.genreBookLabel.Size = new System.Drawing.Size(36, 13);
            this.genreBookLabel.TabIndex = 20;
            this.genreBookLabel.Text = "Műfaj:";
            // 
            // titleBookLabel
            // 
            this.titleBookLabel.AutoSize = true;
            this.titleBookLabel.Location = new System.Drawing.Point(11, 17);
            this.titleBookLabel.Name = "titleBookLabel";
            this.titleBookLabel.Size = new System.Drawing.Size(29, 13);
            this.titleBookLabel.TabIndex = 19;
            this.titleBookLabel.Text = "Cím:";
            // 
            // categoriacomboBox1
            // 
            this.categoriacomboBox1.FormattingEnabled = true;
            this.categoriacomboBox1.Location = new System.Drawing.Point(146, 119);
            this.categoriacomboBox1.Name = "categoriacomboBox1";
            this.categoriacomboBox1.Size = new System.Drawing.Size(128, 21);
            this.categoriacomboBox1.TabIndex = 35;
            // 
            // mufajcomboBox1
            // 
            this.mufajcomboBox1.FormattingEnabled = true;
            this.mufajcomboBox1.Location = new System.Drawing.Point(146, 67);
            this.mufajcomboBox1.Name = "mufajcomboBox1";
            this.mufajcomboBox1.Size = new System.Drawing.Size(128, 21);
            this.mufajcomboBox1.TabIndex = 36;
            // 
            // pageNumbernumericUpDown1
            // 
            this.pageNumbernumericUpDown1.Location = new System.Drawing.Point(146, 146);
            this.pageNumbernumericUpDown1.Name = "pageNumbernumericUpDown1";
            this.pageNumbernumericUpDown1.Size = new System.Drawing.Size(128, 20);
            this.pageNumbernumericUpDown1.TabIndex = 37;
            // 
            // NewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.pageNumbernumericUpDown1);
            this.Controls.Add(this.mufajcomboBox1);
            this.Controls.Add(this.categoriacomboBox1);
            this.Controls.Add(this.cancelBookButton);
            this.Controls.Add(this.addBookButton);
            this.Controls.Add(this.priceBookTextBox);
            this.Controls.Add(this.releaseBookDateTimePicker);
            this.Controls.Add(this.authorBookTextBox);
            this.Controls.Add(this.titleBookTextBox);
            this.Controls.Add(this.pageNumberBookLabel);
            this.Controls.Add(this.priceBookLabel);
            this.Controls.Add(this.categoryBookLabel);
            this.Controls.Add(this.releaseBookDateLabel);
            this.Controls.Add(this.authorBookLabel);
            this.Controls.Add(this.genreBookLabel);
            this.Controls.Add(this.titleBookLabel);
            this.Name = "NewBook";
            this.Text = "Új könyv";
            this.Load += new System.EventHandler(this.NewBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pageNumbernumericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelBookButton;
        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.TextBox priceBookTextBox;
        private System.Windows.Forms.DateTimePicker releaseBookDateTimePicker;
        private System.Windows.Forms.TextBox authorBookTextBox;
        private System.Windows.Forms.TextBox titleBookTextBox;
        private System.Windows.Forms.Label pageNumberBookLabel;
        private System.Windows.Forms.Label priceBookLabel;
        private System.Windows.Forms.Label categoryBookLabel;
        private System.Windows.Forms.Label releaseBookDateLabel;
        private System.Windows.Forms.Label authorBookLabel;
        private System.Windows.Forms.Label genreBookLabel;
        private System.Windows.Forms.Label titleBookLabel;
		private System.Windows.Forms.ComboBox categoriacomboBox1;
		private System.Windows.Forms.ComboBox mufajcomboBox1;
		private System.Windows.Forms.NumericUpDown pageNumbernumericUpDown1;
	}
}