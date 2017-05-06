using BookShopDb.Model;
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

    partial class SajatAdatlap : Form
    {
        private BookShopApp bookShopApp;
        public SajatAdatlap(BookShopApp bookShopApp, Felhasznalo felhasznalo)
        {
            InitializeComponent();
            this.bookShopApp = bookShopApp;

                label5.Text = felhasznalo.k_nev;
                label6.Text = felhasznalo.v_nev;
                label7.Text = felhasznalo.email;
                label8.Text = felhasznalo.tel_szam.ToString();
                label11.Text = felhasznalo.vasarolt_db.ToString();
				Egyenleglabel15.Text = felhasznalo.egyenleg.ToString();

				Utcalabel17.Text = bookShopApp.db_cont.GetLakhelyFromUid(felhasznalo.u_id).utca;
				Hszámlabel18.Text = bookShopApp.db_cont.GetLakhelyFromUid(felhasznalo.u_id).hazszam.ToString();




			if (felhasznalo.admine)
                {
                    label10.Text = "Admin";
                }
                else
                {
                    label10.Text = "Felhasználó";
                }

                if (felhasznalo.torzsvasarlo)
                {
                    label12.Text = "Törzsvásárló";
                }
                else
                {
                    label12.Text = "Nem törzsvásárló";
                }

            this.Visible = true;
        }

        public SajatAdatlap(BookShopApp bookShopApp)
        {
            this.bookShopApp = bookShopApp;
        }

		private void label14_Click(object sender, EventArgs e)
		{

		}

		private void label15_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			new EddigVasaroltam(bookShopApp);
		}
	}
}
