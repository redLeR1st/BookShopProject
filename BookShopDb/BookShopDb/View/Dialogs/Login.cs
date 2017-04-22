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
	public partial class Login : Form
	{
		private BookShopController db_cont = new BookShopController();

		public Login()
		{
			InitializeComponent();
		}

        private BookShopApp bookShopApp;
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
			if (db_cont.Login(login))
				MessageBox.Show("HELYES");
			else
			{
				MessageBox.Show("HELYTELEN");
				MessageBox.Show(login.Username);
				MessageBox.Show(login.Pw);
			}
		}
	}
}
