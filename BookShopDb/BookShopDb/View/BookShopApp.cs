using BookShopDb.View.Dialogs;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BookShopDb.View
{
    public partial class BookShopApp : Form
    {
        public BookShopApp()
        {
            InitializeComponent();
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (NewBook dialog = new NewBook(this))
            {
                dialog.ShowDialog();
            }
        }

        private void filmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (NewFilm dialog = new NewFilm(this))
            {
                dialog.ShowDialog();
            }
        }

        private void musicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (NewMusic dialog = new NewMusic(this))
            {
                dialog.ShowDialog();
            }
        }

        private void newShopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (NewShop dialog = new NewShop(this))
            {
                dialog.ShowDialog();
            }
        }

        private void signInLogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Login dialog = new Login(this))
            {
                dialog.ShowDialog();
            }
        }
    }
}
