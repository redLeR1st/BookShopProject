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
    partial class NewMusic : Form
    {
        private BookShopApp bookShopApp;
        public NewMusic(BookShopApp bookShopApp)
        {
            InitializeComponent();

			this.bookShopApp = bookShopApp;
			mufajcomboBox1.Items.AddRange(new object[] { "Heavy Metal", "Power Metal", "Nu Metal", "Trash Metal", "Hard Rock", "Soft Rock" });
			categoriacomboBox1.Items.AddRange(bookShopApp.db_cont.GetCategoria());
		}

        private void cancelMusicButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		private void addMusicButton_Click(object sender, EventArgs e)
		{
			Tetel temp = new Tetel
			{
				cim = titleMusicTextBox.Text,
				szerzo = authorMusicTextBox.Text,
				mufaj = (string)mufajcomboBox1.SelectedItem,
				kiadasi_datum = releaseMusicDateTimePicker.Value,
				kat_id = bookShopApp.db_cont.GetCategoriaIdByName((string)categoriacomboBox1.SelectedItem),
				ar = Convert.ToInt32(priceMusicTextBox.Text),

				eladott_db = 0,
			};
			if (bookShopApp.db_cont.NewZene(temp, Convert.ToInt32(lengthnumericUpDown1.Value)))
				MessageBox.Show("SIKERÜLT");
			else
				MessageBox.Show("NEM SIKERÜLT");
		}
	
	}
}
