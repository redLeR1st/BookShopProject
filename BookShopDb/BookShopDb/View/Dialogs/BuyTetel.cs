using BookShopDb;
using BookShopDb.Model;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopDb.View.Dialogs
{
	partial class BuyTetel : Form
    {
        Konyv konyv;
		Film film;
		Zene zene;

        private BookShopApp bookShopApp;
		public BuyTetel(BookShopApp bookShopApp, Tetel tetel)
		{
			InitializeComponent();
			this.bookShopApp = bookShopApp;

			if (tetel is Konyv)
			{
				konyv = (Konyv)tetel;
				MessageBox.Show("EZ AZ ID: " + konyv.t_id.ToString());

                label1.Text = "Cím:";
				label2.Text = "Szerző:";
				label3.Text = "Ár:";
				label4.Text = "Értékelés:";
				label5.Text = "Leírás";
				label6.Text = "Komment:";

				label7.Text = konyv.cim;
				label8.Text = konyv.szerzo;
				label9.Text = konyv.ar.ToString();
				label10.Text = bookShopApp.db_cont.GetAdatlapById(konyv).ertekels.ToString();
				label11.Text = bookShopApp.db_cont.GetAdatlapById(konyv).leiras;
				label12.Text = bookShopApp.db_cont.GetAdatlapById(konyv).komment;
			}
            else if (tetel is Film)
            {
                film = (Film)tetel;
                MessageBox.Show("EZ AZ ID: " + film.t_id.ToString());

                label1.Text = "Cím:";
                label2.Text = "Szerző:";
                label3.Text = "Ár:";
                label4.Text = "Értékelés:";
                label5.Text = "Leírás";
                label6.Text = "Komment:";

                label7.Text = film.cim;
                label8.Text = film.szerzo;
                label9.Text = film.ar.ToString();
                label10.Text = bookShopApp.db_cont.GetAdatlapById(film).ertekels.ToString();
                label11.Text = bookShopApp.db_cont.GetAdatlapById(film).leiras;
                label12.Text = bookShopApp.db_cont.GetAdatlapById(film).komment;
            }
            else if (tetel is Zene)
            {
                zene = (Zene)tetel;
                MessageBox.Show("EZ AZ ID: " + zene.t_id.ToString());

                label1.Text = "Cím:";
                label2.Text = "Szerző:";
                label3.Text = "Ár:";
                label4.Text = "Értékelés:";
                label5.Text = "Leírás";
                label6.Text = "Komment:";

                label7.Text = zene.cim;
                label8.Text = zene.szerzo;
                label9.Text = zene.ar.ToString();
                label10.Text = bookShopApp.db_cont.GetAdatlapById(zene).ertekels.ToString();
                label11.Text = bookShopApp.db_cont.GetAdatlapById(zene).leiras;
                label12.Text = bookShopApp.db_cont.GetAdatlapById(zene).komment;
            }
            this.Visible = true;
		}
		/*
		public BuyTetel(BookShopApp bookShopApp, Film tetel)
		{
			InitializeComponent();
			this.bookShopApp = bookShopApp;
			MessageBox.Show("EZ AZ ID: " + tetel.t_id.ToString());

		}

		public BuyTetel(BookShopApp bookShopApp, Zene tetel)
		{
			InitializeComponent();
			this.bookShopApp = bookShopApp;
			MessageBox.Show("EZ AZ ID: " + tetel.t_id.ToString());

		}*/

		private void BuyTetel_Load(object sender, EventArgs e)
		{

		}

		private void Cancelbutton2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Buybutton1_Click(object sender, EventArgs e)
		{
            Vasarol temp = new Vasarol
            {
                u_id = bookShopApp.db_cont.GetOnlineFelhasznalo().u_id,
                t_id = konyv.t_id,
            };
            if (bookShopApp.db_cont.Megveszem(temp))
            {
                MessageBox.Show("Sikerült a vásárlás");
                //vásárolt db, eladott db?
            }
            else
            {
                MessageBox.Show("Nem sikerült a vásárlás");
            }
        }
	}
}
