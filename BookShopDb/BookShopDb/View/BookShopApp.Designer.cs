namespace BookShopDb.View
{
    partial class BookShopApp
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
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.signInLogoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.myProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toplistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.eBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.popularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toplistsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listFilmsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listMusicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.filmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.musicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newShopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cheapBookdataGridView1 = new System.Windows.Forms.DataGridView();
			this.menuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cheapBookdataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.listToolStripMenuItem,
            this.newToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(784, 24);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "menuStrip";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signInLogoutToolStripMenuItem,
            this.myProfileToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// signInLogoutToolStripMenuItem
			// 
			this.signInLogoutToolStripMenuItem.Name = "signInLogoutToolStripMenuItem";
			this.signInLogoutToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.signInLogoutToolStripMenuItem.Text = "Sign In/Logout";
			this.signInLogoutToolStripMenuItem.Click += new System.EventHandler(this.signInLogoutToolStripMenuItem_Click);
			// 
			// myProfileToolStripMenuItem
			// 
			this.myProfileToolStripMenuItem.Name = "myProfileToolStripMenuItem";
			this.myProfileToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.myProfileToolStripMenuItem.Text = "My Profile";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			// 
			// listToolStripMenuItem
			// 
			this.listToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listBooksToolStripMenuItem,
            this.listFilmsToolStripMenuItem,
            this.listMusicsToolStripMenuItem});
			this.listToolStripMenuItem.Name = "listToolStripMenuItem";
			this.listToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.listToolStripMenuItem.Text = "&List";
			// 
			// listBooksToolStripMenuItem
			// 
			this.listBooksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toplistToolStripMenuItem,
            this.eBooksToolStripMenuItem,
            this.popularToolStripMenuItem,
            this.toplistsToolStripMenuItem});
			this.listBooksToolStripMenuItem.Name = "listBooksToolStripMenuItem";
			this.listBooksToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.listBooksToolStripMenuItem.Text = "List Books";
			// 
			// toplistToolStripMenuItem
			// 
			this.toplistToolStripMenuItem.Name = "toplistToolStripMenuItem";
			this.toplistToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.toplistToolStripMenuItem.Text = "Cheapest";
			this.toplistToolStripMenuItem.Click += new System.EventHandler(this.toplistToolStripMenuItem_Click);
			// 
			// eBooksToolStripMenuItem
			// 
			this.eBooksToolStripMenuItem.Name = "eBooksToolStripMenuItem";
			this.eBooksToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.eBooksToolStripMenuItem.Text = "E-Books";
			// 
			// popularToolStripMenuItem
			// 
			this.popularToolStripMenuItem.Name = "popularToolStripMenuItem";
			this.popularToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.popularToolStripMenuItem.Text = "Most Populars";
			this.popularToolStripMenuItem.Click += new System.EventHandler(this.popularToolStripMenuItem_Click);
			// 
			// toplistsToolStripMenuItem
			// 
			this.toplistsToolStripMenuItem.Name = "toplistsToolStripMenuItem";
			this.toplistsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.toplistsToolStripMenuItem.Text = "Toplists";
			// 
			// listFilmsToolStripMenuItem
			// 
			this.listFilmsToolStripMenuItem.Name = "listFilmsToolStripMenuItem";
			this.listFilmsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.listFilmsToolStripMenuItem.Text = "List Films";
			// 
			// listMusicsToolStripMenuItem
			// 
			this.listMusicsToolStripMenuItem.Name = "listMusicsToolStripMenuItem";
			this.listMusicsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.listMusicsToolStripMenuItem.Text = "List Musics";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newItemToolStripMenuItem,
            this.newShopToolStripMenuItem});
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
			this.newToolStripMenuItem.Text = "&New";
			// 
			// newItemToolStripMenuItem
			// 
			this.newItemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookToolStripMenuItem,
            this.filmToolStripMenuItem,
            this.musicToolStripMenuItem});
			this.newItemToolStripMenuItem.Name = "newItemToolStripMenuItem";
			this.newItemToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
			this.newItemToolStripMenuItem.Text = "New Item";
			// 
			// bookToolStripMenuItem
			// 
			this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
			this.bookToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
			this.bookToolStripMenuItem.Text = "Book";
			this.bookToolStripMenuItem.Click += new System.EventHandler(this.bookToolStripMenuItem_Click);
			// 
			// filmToolStripMenuItem
			// 
			this.filmToolStripMenuItem.Name = "filmToolStripMenuItem";
			this.filmToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
			this.filmToolStripMenuItem.Text = "Film";
			this.filmToolStripMenuItem.Click += new System.EventHandler(this.filmToolStripMenuItem_Click);
			// 
			// musicToolStripMenuItem
			// 
			this.musicToolStripMenuItem.Name = "musicToolStripMenuItem";
			this.musicToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
			this.musicToolStripMenuItem.Text = "Music";
			this.musicToolStripMenuItem.Click += new System.EventHandler(this.musicToolStripMenuItem_Click);
			// 
			// newShopToolStripMenuItem
			// 
			this.newShopToolStripMenuItem.Name = "newShopToolStripMenuItem";
			this.newShopToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
			this.newShopToolStripMenuItem.Text = "New Shop";
			this.newShopToolStripMenuItem.Click += new System.EventHandler(this.newShopToolStripMenuItem_Click);
			// 
			// cheapBookdataGridView1
			// 
			this.cheapBookdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.cheapBookdataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cheapBookdataGridView1.Location = new System.Drawing.Point(0, 24);
			this.cheapBookdataGridView1.Name = "cheapBookdataGridView1";
			this.cheapBookdataGridView1.Size = new System.Drawing.Size(784, 537);
			this.cheapBookdataGridView1.TabIndex = 1;
			// 
			// BookShopApp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.cheapBookdataGridView1);
			this.Controls.Add(this.menuStrip);
			this.MainMenuStrip = this.menuStrip;
			this.Name = "BookShopApp";
			this.Text = "BookShop Application";
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.cheapBookdataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signInLogoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toplistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem popularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toplistsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listFilmsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listMusicsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newShopToolStripMenuItem;
		private System.Windows.Forms.DataGridView cheapBookdataGridView1;
	}
}