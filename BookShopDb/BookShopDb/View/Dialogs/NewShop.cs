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
    partial class NewShop : Form
    {
        private BookShopApp bookShopApp;
        public NewShop(BookShopApp bookShopApp)
        {
            InitializeComponent();

            this.bookShopApp = bookShopApp;
        }

        private void cancelShopButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addShopButton_Click(object sender, EventArgs e)
        {
            Aruhaz temp = new Aruhaz
            {
                nev = shopNameTextBox.Text,
                cim = addressShopTextBox.Text,
            };
            if (bookShopApp.db_cont.NewShop(temp))
            {
                MessageBox.Show("Sikerült az áruház hozzáadása");
            }
            else
            {
                MessageBox.Show("Nem sikerült az áruház hozzáadása");
            }
        }
    }
}
