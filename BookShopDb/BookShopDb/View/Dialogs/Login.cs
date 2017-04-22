using BookShopDb.Controller;
using BookShopDb.Model;
using BookShopDb.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopDb
{
	partial class Login : Form
	{
		
        BookShopApp bookShopApp;

		public Login(BookShopApp bookShopApp)
        {
            InitializeComponent();

            this.bookShopApp = bookShopApp;
        }

        private void loginbutton1_Click(object sender, EventArgs e)
		{
            Model.Login login = new Model.Login()
			{
				Username = usertextBox1.Text,
				Pw = pwtextBox2.Text
			};
			if (bookShopApp.db_cont.Login(login))
			{
				if (bookShopApp.db_cont.GetOnlineFelhasznalo() != null)
				{
					bookShopApp.Text = "Üdvözöllek, " + bookShopApp.db_cont.GetOnlineFelhasznalo().k_nev;
				}
				this.Visible = false;
			}
				
			else
			{
				MessageBox.Show("Helytelen jelszó-pw páros!");
			}
		}

		private void signUpLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{

		}
	}
}
