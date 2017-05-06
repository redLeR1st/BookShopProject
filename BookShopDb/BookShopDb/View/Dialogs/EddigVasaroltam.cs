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
    partial class EddigVasaroltam : Form
    {
		BookShopApp bookShopApp;

		public EddigVasaroltam(BookShopApp bookShopApp)
        {
            InitializeComponent();

			this.bookShopApp = bookShopApp;

			KonyvdataGridView1.DataSource = bookShopApp.db_cont.GetMegvettKonyvek(bookShopApp.db_cont.GetOnlineFelhasznalo().u_id);
			FilmdataGridView2.DataSource = bookShopApp.db_cont.GetMegvettFilmek(bookShopApp.db_cont.GetOnlineFelhasznalo().u_id);
			ZenedataGridView3.DataSource = bookShopApp.db_cont.GetMegvettZenek(bookShopApp.db_cont.GetOnlineFelhasznalo().u_id);

			Visible = true;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void KonyvdataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
