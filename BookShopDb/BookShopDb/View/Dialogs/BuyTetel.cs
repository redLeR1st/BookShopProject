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
		Tetel tetel;

        private BookShopApp bookShopApp;
		public BuyTetel(BookShopApp bookShopApp, Tetel tetel)
		{
			InitializeComponent();
			this.bookShopApp = bookShopApp;

			
			this.tetel = tetel;
			//MessageBox.Show("EZ AZ ID: " + konyv.t_id.ToString());

            label1.Text = "Cím:";
			label2.Text = "Szerző:";
			label3.Text = "Ár:";
			label4.Text = "Értékelés:";
			label5.Text = "Leírás";
			label6.Text = "Komment:";

			label7.Text = tetel.cim;
			label8.Text = tetel.szerzo;
			label9.Text = tetel.ar.ToString();
			label10.Text = bookShopApp.db_cont.GetAdatlapById(tetel).ertekels.ToString();
			label11.Text = bookShopApp.db_cont.GetAdatlapById(tetel).leiras;
			label12.Text = bookShopApp.db_cont.GetAdatlapById(tetel).komment;
			
            
            this.Visible = true;
		}

		private void BuyTetel_Load(object sender, EventArgs e)
		{

		}

		private void Cancelbutton2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Buybutton1_Click(object sender, EventArgs e)
		{
			if (bookShopApp.db_cont.GetOnlineFelhasznalo() != null)
			{
				if (bookShopApp.db_cont.GetOnlineFelhasznalo().egyenleg >= bookShopApp.db_cont.GetTetelFromTid(tetel.t_id).ar)
				{

					Vasarol temp = new Vasarol
					{
						u_id = bookShopApp.db_cont.GetOnlineFelhasznalo().u_id,
						t_id = tetel.t_id,
					};
					if (bookShopApp.db_cont.Megveszem(temp))
					{
						MessageBox.Show("Sikerült a vásárlás");

					}
					else
					{
						MessageBox.Show("Nem sikerült a vásárlás");
					}
				}
				else
					MessageBox.Show("Nincs elég pénzed");
			}
			else
				MessageBox.Show("Jelentkezz be ha vásárloni akarsz");
				
		}
	}
}
