namespace BookShopDb.View.Dialogs
{
    partial class NewShop
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
            this.shopNameLabel = new System.Windows.Forms.Label();
            this.addressShopLabel = new System.Windows.Forms.Label();
            this.cancelShopButton = new System.Windows.Forms.Button();
            this.addShopButton = new System.Windows.Forms.Button();
            this.addressShopTextBox = new System.Windows.Forms.TextBox();
            this.shopNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // shopNameLabel
            // 
            this.shopNameLabel.AutoSize = true;
            this.shopNameLabel.Location = new System.Drawing.Point(22, 23);
            this.shopNameLabel.Name = "shopNameLabel";
            this.shopNameLabel.Size = new System.Drawing.Size(66, 13);
            this.shopNameLabel.TabIndex = 0;
            this.shopNameLabel.Text = "Shop Name:";
            // 
            // addressShopLabel
            // 
            this.addressShopLabel.AutoSize = true;
            this.addressShopLabel.Location = new System.Drawing.Point(22, 50);
            this.addressShopLabel.Name = "addressShopLabel";
            this.addressShopLabel.Size = new System.Drawing.Size(48, 13);
            this.addressShopLabel.TabIndex = 1;
            this.addressShopLabel.Text = "Address:";
            // 
            // cancelShopButton
            // 
            this.cancelShopButton.Location = new System.Drawing.Point(157, 93);
            this.cancelShopButton.Name = "cancelShopButton";
            this.cancelShopButton.Size = new System.Drawing.Size(75, 23);
            this.cancelShopButton.TabIndex = 52;
            this.cancelShopButton.Text = "&Cancel";
            this.cancelShopButton.UseVisualStyleBackColor = true;
            this.cancelShopButton.Click += new System.EventHandler(this.cancelShopButton_Click);
            // 
            // addShopButton
            // 
            this.addShopButton.Location = new System.Drawing.Point(51, 93);
            this.addShopButton.Name = "addShopButton";
            this.addShopButton.Size = new System.Drawing.Size(75, 23);
            this.addShopButton.TabIndex = 51;
            this.addShopButton.Text = "&Add";
            this.addShopButton.UseVisualStyleBackColor = true;
            // 
            // addressShopTextBox
            // 
            this.addressShopTextBox.Location = new System.Drawing.Point(118, 46);
            this.addressShopTextBox.Name = "addressShopTextBox";
            this.addressShopTextBox.Size = new System.Drawing.Size(128, 20);
            this.addressShopTextBox.TabIndex = 54;
            // 
            // shopNameTextBox
            // 
            this.shopNameTextBox.Location = new System.Drawing.Point(118, 20);
            this.shopNameTextBox.Name = "shopNameTextBox";
            this.shopNameTextBox.Size = new System.Drawing.Size(128, 20);
            this.shopNameTextBox.TabIndex = 53;
            // 
            // NewShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 137);
            this.Controls.Add(this.addressShopTextBox);
            this.Controls.Add(this.shopNameTextBox);
            this.Controls.Add(this.cancelShopButton);
            this.Controls.Add(this.addShopButton);
            this.Controls.Add(this.addressShopLabel);
            this.Controls.Add(this.shopNameLabel);
            this.Name = "NewShop";
            this.Text = "New Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label shopNameLabel;
        private System.Windows.Forms.Label addressShopLabel;
        private System.Windows.Forms.Button cancelShopButton;
        private System.Windows.Forms.Button addShopButton;
        private System.Windows.Forms.TextBox addressShopTextBox;
        private System.Windows.Forms.TextBox shopNameTextBox;
    }
}