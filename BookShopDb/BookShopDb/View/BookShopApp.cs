﻿using BookShopDb.View.Dialogs;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BookShopDb.Controller;
using BookShopDb.Model;

namespace BookShopDb.View
{
    partial class BookShopApp : Form
    {
		public BookShopController db_cont = new BookShopController();
		string listazott_elemek = null;

		public BookShopApp()
		{
			InitializeComponent();
			UniversaldataGridView1.ReadOnly = true;
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
			if (db_cont.BookShopDao.OnlineFelhasznalo != null && db_cont.BookShopDao.OnlineFelhasznalo.admine)
			{
				using (NewFilm dialog = new NewFilm(this))
				{
					dialog.ShowDialog(this);
				}
			}
			else
				MessageBox.Show("Nem vagy bejelentkezve vagy nincs jogosultságod úgy könyv felvételére :/");

		}

		private void musicToolStripMenuItem_Click(object sender, EventArgs e)
        {
			if (db_cont.BookShopDao.OnlineFelhasznalo != null && db_cont.BookShopDao.OnlineFelhasznalo.admine)
			{
				using (NewMusic dialog = new NewMusic(this))
				{
					dialog.ShowDialog(this);
				}
			}
			else
				MessageBox.Show("Nem vagy bejelentkezve vagy nincs jogosultságod úgy könyv felvételére :/");
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
            if (db_cont.BookShopDao.OnlineFelhasznalo == null)
            {
                using (Login dialog = new Login(this))
                {
                    dialog.ShowDialog(this);
                }
            }else
            {
                db_cont.BookShopDao.OnlineFelhasznalo = null;
				this.Text = "BookShop alkalmazás";
            }
        }

		private void toplistToolStripMenuItem_Click(object sender, EventArgs e)
		{
            pictureBox1.Hide();
			listazott_elemek = "konyv";
			UniversaldataGridView1.DataSource = null;
			UniversaldataGridView1.DataSource = db_cont.GetKonyvekFromCheapest();
			UniversaldataGridView1.Visible = true;
		}

		private void popularToolStripMenuItem_Click(object sender, EventArgs e)
		{
            pictureBox1.Hide();
            listazott_elemek = "konyv";
			UniversaldataGridView1.DataSource = null;
			UniversaldataGridView1.DataSource = db_cont.GetKonyvekFromMostPopular();
			UniversaldataGridView1.Visible = true;
		}

        private void listFilmsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            listazott_elemek = "film";
			UniversaldataGridView1.DataSource = null;
			UniversaldataGridView1.DataSource = db_cont.GetFilmek();
			UniversaldataGridView1.Visible = true;
		}

		private void listMusicsToolStripMenuItem_Click(object sender, EventArgs e)
		{
            pictureBox1.Hide();
            listazott_elemek = "zene";
			UniversaldataGridView1.DataSource = null;
			UniversaldataGridView1.DataSource = db_cont.GetZenek();
			UniversaldataGridView1.Visible = true;
		}

		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void UniversaldataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
            pictureBox1.Hide();
            Tetel temp;
			temp = (Tetel)UniversaldataGridView1.CurrentRow.DataBoundItem;
			if (temp != null)
				new BuyTetel(this, temp);

			/*
			if (listazott_elemek.Equals("konyv"))
			{
				temp = (Konyv)UniversaldataGridView1.CurrentRow.DataBoundItem;
				if (temp != null)
					new BuyTetel(this, temp);

			}
			else if (listazott_elemek.Equals("film"))
			{
				temp = (Film)UniversaldataGridView1.CurrentRow.DataBoundItem;
				if (temp != null)
					new BuyTetel(this, temp);

			}
			else if (listazott_elemek.Equals("zene"))
			{
				temp = (Zene)UniversaldataGridView1.CurrentRow.DataBoundItem;
				if (temp != null)
					new BuyTetel(this, temp);

			}
			else
				MessageBox.Show("Valami nagyon nagy gebasz van");*/
				

		}

        private void myProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
			if (db_cont.BookShopDao.OnlineFelhasznalo != null)
            {
				new Login(this);
		        new SajatAdatlap(this, db_cont.GetOnlineFelhasznalo());
            }
			else
            {
				MessageBox.Show("Adatlapod megtekintéséhez először be kell jelentkezned!");
			}
            
        }
    }
}
