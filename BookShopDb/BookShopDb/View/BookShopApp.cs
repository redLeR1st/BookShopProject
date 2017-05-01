using BookShopDb.View.Dialogs;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BookShopDb.Controller;

namespace BookShopDb.View
{
    partial class BookShopApp : Form
    {
		public BookShopController db_cont = new BookShopController();

		public BookShopApp()
		{
			InitializeComponent();
		}

		private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
			if (db_cont.BookShopDao.OnlineFelhasznalo != null && db_cont.BookShopDao.OnlineFelhasznalo.admine)
			{
				using (NewBook dialog = new NewBook(this))
				{
					dialog.ShowDialog(this);
				}
			}
			else
				MessageBox.Show("Nem vagy bejelentkezve vagy nincs jogosultságod úgy könyv felvételére :/");
			
        }

        private void filmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (NewFilm dialog = new NewFilm(this))
            {
                dialog.ShowDialog(this);
            }
        }

        private void musicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (NewMusic dialog = new NewMusic(this))
            {
                dialog.ShowDialog(this);
            }
        }

        private void newShopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (NewShop dialog = new NewShop(this))
            {
                dialog.ShowDialog(this);
            }
        }

        private void signInLogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Login dialog = new Login(this))
            {
                dialog.ShowDialog(this);
            }
        }

		private void toplistToolStripMenuItem_Click(object sender, EventArgs e)
		{
			cheapBookdataGridView1.DataSource = null;
			cheapBookdataGridView1.DataSource = db_cont.GetKonyvekFromCheapest();
			cheapBookdataGridView1.Visible = true;
		}

		private void popularToolStripMenuItem_Click(object sender, EventArgs e)
		{
			cheapBookdataGridView1.DataSource = null;
			cheapBookdataGridView1.DataSource = db_cont.GetKonyvekFromMostPopular();
			cheapBookdataGridView1.Visible = true;
		}

        private void listFilmsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ListFilms dialog = new ListFilms())
            {
                dialog.ShowDialog(this);
            }
        }
    }
}
