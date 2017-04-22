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
            this.pageNumberBookTextBox = new System.Windows.Forms.TextBox();
            this.categoryBookTextBox = new System.Windows.Forms.TextBox();
            this.genreBookTextBox = new System.Windows.Forms.TextBox();
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
            this.SuspendLayout();
            // 
            // cancelBookButton
            // 
            this.cancelBookButton.Location = new System.Drawing.Point(157, 224);
            this.cancelBookButton.Name = "cancelBookButton";
            this.cancelBookButton.Size = new System.Drawing.Size(75, 23);
            this.cancelBookButton.TabIndex = 34;
            this.cancelBookButton.Text = "&Cancel";
            this.cancelBookButton.UseVisualStyleBackColor = true;
            this.cancelBookButton.Click += new System.EventHandler(this.cancelBookButton_Click);
            // 
            // addBookButton
            // 
            this.addBookButton.Location = new System.Drawing.Point(51, 224);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(75, 23);
            this.addBookButton.TabIndex = 33;
            this.addBookButton.Text = "&Add";
            this.addBookButton.UseVisualStyleBackColor = true;
            // 
            // priceBookTextBox
            // 
            this.priceBookTextBox.Location = new System.Drawing.Point(146, 171);
            this.priceBookTextBox.Name = "priceBookTextBox";
            this.priceBookTextBox.Size = new System.Drawing.Size(128, 20);
            this.priceBookTextBox.TabIndex = 32;
            // 
            // pageNumberBookTextBox
            // 
            this.pageNumberBookTextBox.Location = new System.Drawing.Point(146, 145);
            this.pageNumberBookTextBox.Name = "pageNumberBookTextBox";
            this.pageNumberBookTextBox.Size = new System.Drawing.Size(128, 20);
            this.pageNumberBookTextBox.TabIndex = 31;
            // 
            // categoryBookTextBox
            // 
            this.categoryBookTextBox.Location = new System.Drawing.Point(146, 119);
            this.categoryBookTextBox.Name = "categoryBookTextBox";
            this.categoryBookTextBox.Size = new System.Drawing.Size(128, 20);
            this.categoryBookTextBox.TabIndex = 30;
            // 
            // genreBookTextBox
            // 
            this.genreBookTextBox.Location = new System.Drawing.Point(146, 67);
            this.genreBookTextBox.Name = "genreBookTextBox";
            this.genreBookTextBox.Size = new System.Drawing.Size(128, 20);
            this.genreBookTextBox.TabIndex = 29;
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
            this.pageNumberBookLabel.Size = new System.Drawing.Size(73, 13);
            this.pageNumberBookLabel.TabIndex = 25;
            this.pageNumberBookLabel.Text = "Page number:";
            // 
            // priceBookLabel
            // 
            this.priceBookLabel.AutoSize = true;
            this.priceBookLabel.Location = new System.Drawing.Point(11, 174);
            this.priceBookLabel.Name = "priceBookLabel";
            this.priceBookLabel.Size = new System.Drawing.Size(34, 13);
            this.priceBookLabel.TabIndex = 24;
            this.priceBookLabel.Text = "Price:";
            // 
            // categoryBookLabel
            // 
            this.categoryBookLabel.AutoSize = true;
            this.categoryBookLabel.Location = new System.Drawing.Point(11, 122);
            this.categoryBookLabel.Name = "categoryBookLabel";
            this.categoryBookLabel.Size = new System.Drawing.Size(52, 13);
            this.categoryBookLabel.TabIndex = 23;
            this.categoryBookLabel.Text = "Category:";
            // 
            // releaseBookDateLabel
            // 
            this.releaseBookDateLabel.AutoSize = true;
            this.releaseBookDateLabel.Location = new System.Drawing.Point(11, 99);
            this.releaseBookDateLabel.Name = "releaseBookDateLabel";
            this.releaseBookDateLabel.Size = new System.Drawing.Size(73, 13);
            this.releaseBookDateLabel.TabIndex = 22;
            this.releaseBookDateLabel.Text = "Release date:";
            // 
            // authorBookLabel
            // 
            this.authorBookLabel.AutoSize = true;
            this.authorBookLabel.Location = new System.Drawing.Point(11, 44);
            this.authorBookLabel.Name = "authorBookLabel";
            this.authorBookLabel.Size = new System.Drawing.Size(41, 13);
            this.authorBookLabel.TabIndex = 21;
            this.authorBookLabel.Text = "Author:";
            // 
            // genreBookLabel
            // 
            this.genreBookLabel.AutoSize = true;
            this.genreBookLabel.Location = new System.Drawing.Point(11, 70);
            this.genreBookLabel.Name = "genreBookLabel";
            this.genreBookLabel.Size = new System.Drawing.Size(39, 13);
            this.genreBookLabel.TabIndex = 20;
            this.genreBookLabel.Text = "Genre:";
            // 
            // titleBookLabel
            // 
            this.titleBookLabel.AutoSize = true;
            this.titleBookLabel.Location = new System.Drawing.Point(11, 17);
            this.titleBookLabel.Name = "titleBookLabel";
            this.titleBookLabel.Size = new System.Drawing.Size(30, 13);
            this.titleBookLabel.TabIndex = 19;
            this.titleBookLabel.Text = "Title:";
            // 
            // NewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cancelBookButton);
            this.Controls.Add(this.addBookButton);
            this.Controls.Add(this.priceBookTextBox);
            this.Controls.Add(this.pageNumberBookTextBox);
            this.Controls.Add(this.categoryBookTextBox);
            this.Controls.Add(this.genreBookTextBox);
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
            this.Text = "New Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelBookButton;
        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.TextBox priceBookTextBox;
        private System.Windows.Forms.TextBox pageNumberBookTextBox;
        private System.Windows.Forms.TextBox categoryBookTextBox;
        private System.Windows.Forms.TextBox genreBookTextBox;
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
    }
}