namespace BookShopDb.View.Dialogs
{
    partial class NewFilm
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
            this.cancelFilmButton = new System.Windows.Forms.Button();
            this.addFilmButton = new System.Windows.Forms.Button();
            this.priceFilmTextBox = new System.Windows.Forms.TextBox();
            this.releaseFilmDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.authorFilmTextBox = new System.Windows.Forms.TextBox();
            this.titleFilmTextBox = new System.Windows.Forms.TextBox();
            this.lengthFilmLabel = new System.Windows.Forms.Label();
            this.priceFilmLabel = new System.Windows.Forms.Label();
            this.categoryFilmLabel = new System.Windows.Forms.Label();
            this.releaseDateFilmLabel = new System.Windows.Forms.Label();
            this.authorFilmLabel = new System.Windows.Forms.Label();
            this.genreFilmLabel = new System.Windows.Forms.Label();
            this.titleFilmLabel = new System.Windows.Forms.Label();
            this.mufajcomboBox1 = new System.Windows.Forms.ComboBox();
            this.categoriacomboBox1 = new System.Windows.Forms.ComboBox();
            this.lengthnumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.lengthnumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelFilmButton
            // 
            this.cancelFilmButton.Location = new System.Drawing.Point(157, 224);
            this.cancelFilmButton.Name = "cancelFilmButton";
            this.cancelFilmButton.Size = new System.Drawing.Size(75, 23);
            this.cancelFilmButton.TabIndex = 34;
            this.cancelFilmButton.Text = "&Mégse";
            this.cancelFilmButton.UseVisualStyleBackColor = true;
            this.cancelFilmButton.Click += new System.EventHandler(this.cancelFilmButton_Click);
            // 
            // addFilmButton
            // 
            this.addFilmButton.Location = new System.Drawing.Point(51, 224);
            this.addFilmButton.Name = "addFilmButton";
            this.addFilmButton.Size = new System.Drawing.Size(75, 23);
            this.addFilmButton.TabIndex = 33;
            this.addFilmButton.Text = "&Hozzáadás";
            this.addFilmButton.UseVisualStyleBackColor = true;
            this.addFilmButton.Click += new System.EventHandler(this.addFilmButton_Click);
            // 
            // priceFilmTextBox
            // 
            this.priceFilmTextBox.Location = new System.Drawing.Point(146, 171);
            this.priceFilmTextBox.Name = "priceFilmTextBox";
            this.priceFilmTextBox.Size = new System.Drawing.Size(128, 20);
            this.priceFilmTextBox.TabIndex = 32;
            // 
            // releaseFilmDateTimePicker
            // 
            this.releaseFilmDateTimePicker.Location = new System.Drawing.Point(146, 93);
            this.releaseFilmDateTimePicker.Name = "releaseFilmDateTimePicker";
            this.releaseFilmDateTimePicker.Size = new System.Drawing.Size(128, 20);
            this.releaseFilmDateTimePicker.TabIndex = 28;
            // 
            // authorFilmTextBox
            // 
            this.authorFilmTextBox.Location = new System.Drawing.Point(146, 41);
            this.authorFilmTextBox.Name = "authorFilmTextBox";
            this.authorFilmTextBox.Size = new System.Drawing.Size(128, 20);
            this.authorFilmTextBox.TabIndex = 27;
            // 
            // titleFilmTextBox
            // 
            this.titleFilmTextBox.Location = new System.Drawing.Point(146, 14);
            this.titleFilmTextBox.Name = "titleFilmTextBox";
            this.titleFilmTextBox.Size = new System.Drawing.Size(128, 20);
            this.titleFilmTextBox.TabIndex = 26;
            // 
            // lengthFilmLabel
            // 
            this.lengthFilmLabel.AutoSize = true;
            this.lengthFilmLabel.Location = new System.Drawing.Point(11, 148);
            this.lengthFilmLabel.Name = "lengthFilmLabel";
            this.lengthFilmLabel.Size = new System.Drawing.Size(39, 13);
            this.lengthFilmLabel.TabIndex = 25;
            this.lengthFilmLabel.Text = "Hossz:";
            // 
            // priceFilmLabel
            // 
            this.priceFilmLabel.AutoSize = true;
            this.priceFilmLabel.Location = new System.Drawing.Point(11, 174);
            this.priceFilmLabel.Name = "priceFilmLabel";
            this.priceFilmLabel.Size = new System.Drawing.Size(20, 13);
            this.priceFilmLabel.TabIndex = 24;
            this.priceFilmLabel.Text = "Ár:";
            // 
            // categoryFilmLabel
            // 
            this.categoryFilmLabel.AutoSize = true;
            this.categoryFilmLabel.Location = new System.Drawing.Point(11, 122);
            this.categoryFilmLabel.Name = "categoryFilmLabel";
            this.categoryFilmLabel.Size = new System.Drawing.Size(55, 13);
            this.categoryFilmLabel.TabIndex = 23;
            this.categoryFilmLabel.Text = "Kategória:";
            // 
            // releaseDateFilmLabel
            // 
            this.releaseDateFilmLabel.AutoSize = true;
            this.releaseDateFilmLabel.Location = new System.Drawing.Point(11, 99);
            this.releaseDateFilmLabel.Name = "releaseDateFilmLabel";
            this.releaseDateFilmLabel.Size = new System.Drawing.Size(76, 13);
            this.releaseDateFilmLabel.TabIndex = 22;
            this.releaseDateFilmLabel.Text = "Kiadási dátum:";
            // 
            // authorFilmLabel
            // 
            this.authorFilmLabel.AutoSize = true;
            this.authorFilmLabel.Location = new System.Drawing.Point(11, 44);
            this.authorFilmLabel.Name = "authorFilmLabel";
            this.authorFilmLabel.Size = new System.Drawing.Size(42, 13);
            this.authorFilmLabel.TabIndex = 21;
            this.authorFilmLabel.Text = "Szerző:";
            // 
            // genreFilmLabel
            // 
            this.genreFilmLabel.AutoSize = true;
            this.genreFilmLabel.Location = new System.Drawing.Point(11, 70);
            this.genreFilmLabel.Name = "genreFilmLabel";
            this.genreFilmLabel.Size = new System.Drawing.Size(36, 13);
            this.genreFilmLabel.TabIndex = 20;
            this.genreFilmLabel.Text = "Műfaj:";
            // 
            // titleFilmLabel
            // 
            this.titleFilmLabel.AutoSize = true;
            this.titleFilmLabel.Location = new System.Drawing.Point(11, 17);
            this.titleFilmLabel.Name = "titleFilmLabel";
            this.titleFilmLabel.Size = new System.Drawing.Size(29, 13);
            this.titleFilmLabel.TabIndex = 19;
            this.titleFilmLabel.Text = "Cím:";
            // 
            // mufajcomboBox1
            // 
            this.mufajcomboBox1.FormattingEnabled = true;
            this.mufajcomboBox1.Location = new System.Drawing.Point(146, 66);
            this.mufajcomboBox1.Name = "mufajcomboBox1";
            this.mufajcomboBox1.Size = new System.Drawing.Size(128, 21);
            this.mufajcomboBox1.TabIndex = 35;
            // 
            // categoriacomboBox1
            // 
            this.categoriacomboBox1.FormattingEnabled = true;
            this.categoriacomboBox1.Location = new System.Drawing.Point(146, 118);
            this.categoriacomboBox1.Name = "categoriacomboBox1";
            this.categoriacomboBox1.Size = new System.Drawing.Size(128, 21);
            this.categoriacomboBox1.TabIndex = 36;
            // 
            // lengthnumericUpDown1
            // 
            this.lengthnumericUpDown1.Location = new System.Drawing.Point(146, 145);
            this.lengthnumericUpDown1.Name = "lengthnumericUpDown1";
            this.lengthnumericUpDown1.Size = new System.Drawing.Size(128, 20);
            this.lengthnumericUpDown1.TabIndex = 37;
            // 
            // NewFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lengthnumericUpDown1);
            this.Controls.Add(this.categoriacomboBox1);
            this.Controls.Add(this.mufajcomboBox1);
            this.Controls.Add(this.cancelFilmButton);
            this.Controls.Add(this.addFilmButton);
            this.Controls.Add(this.priceFilmTextBox);
            this.Controls.Add(this.releaseFilmDateTimePicker);
            this.Controls.Add(this.authorFilmTextBox);
            this.Controls.Add(this.titleFilmTextBox);
            this.Controls.Add(this.lengthFilmLabel);
            this.Controls.Add(this.priceFilmLabel);
            this.Controls.Add(this.categoryFilmLabel);
            this.Controls.Add(this.releaseDateFilmLabel);
            this.Controls.Add(this.authorFilmLabel);
            this.Controls.Add(this.genreFilmLabel);
            this.Controls.Add(this.titleFilmLabel);
            this.Name = "NewFilm";
            this.Text = "Új film";
            ((System.ComponentModel.ISupportInitialize)(this.lengthnumericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelFilmButton;
        private System.Windows.Forms.Button addFilmButton;
        private System.Windows.Forms.TextBox priceFilmTextBox;
        private System.Windows.Forms.DateTimePicker releaseFilmDateTimePicker;
        private System.Windows.Forms.TextBox authorFilmTextBox;
        private System.Windows.Forms.TextBox titleFilmTextBox;
        private System.Windows.Forms.Label lengthFilmLabel;
        private System.Windows.Forms.Label priceFilmLabel;
        private System.Windows.Forms.Label categoryFilmLabel;
        private System.Windows.Forms.Label releaseDateFilmLabel;
        private System.Windows.Forms.Label authorFilmLabel;
        private System.Windows.Forms.Label genreFilmLabel;
        private System.Windows.Forms.Label titleFilmLabel;
		private System.Windows.Forms.ComboBox mufajcomboBox1;
		private System.Windows.Forms.ComboBox categoriacomboBox1;
		private System.Windows.Forms.NumericUpDown lengthnumericUpDown1;
	}
}