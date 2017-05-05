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

                label5.Text = bookShopApp.db_cont.GetOnlineFelhasznalo().k_nev;
                label6.Text = bookShopApp.db_cont.GetOnlineFelhasznalo().v_nev;
                label7.Text = bookShopApp.db_cont.GetOnlineFelhasznalo().email;
                label8.Text = bookShopApp.db_cont.GetOnlineFelhasznalo().tel_szam.ToString();
                label11.Text = bookShopApp.db_cont.GetOnlineFelhasznalo().vasarolt_db.ToString();

                if (bookShopApp.db_cont.GetOnlineFelhasznalo().admine)
                {
                    label10.Text = "Admin";
                }
                else
                {
                    label10.Text = "Felhasználó";
                }

                if (bookShopApp.db_cont.GetOnlineFelhasznalo().torzsvasarlo)
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
    }
}
