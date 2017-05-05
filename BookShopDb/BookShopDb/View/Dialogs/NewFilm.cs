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
    partial class NewFilm : Form
    {
        private BookShopApp bookShopApp;
        public NewFilm(BookShopApp bookShopApp)
        {
            InitializeComponent();

			this.bookShopApp = bookShopApp;
			mufajcomboBox1.Items.AddRange(new object[] { "Horror", "Scifi", "Komédia", "Dráma" });
			categoriacomboBox1.Items.AddRange(bookShopApp.db_cont.GetCategoria());
		}

        private void cancelFilmButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		private void addFilmButton_Click(object sender, EventArgs e)
		{
			Tetel temp = new Tetel
			{
				cim = titleFilmTextBox.Text,
				szerzo = authorFilmTextBox.Text,
				mufaj = (string)mufajcomboBox1.SelectedItem,
				kiadasi_datum = releaseFilmDateTimePicker.Value,
				kat_id = bookShopApp.db_cont.GetCategoriaIdByName((string)categoriacomboBox1.SelectedItem),
				ar = Convert.ToInt32(priceFilmTextBox.Text),

				eladott_db = 0,
			};
			if (bookShopApp.db_cont.NewFilm(temp, Convert.ToInt32(lengthnumericUpDown1.Value)))
				MessageBox.Show("Sikerült a film hozzáadása");
			else
				MessageBox.Show("Nem sikerült a film hozzáadása");
		}
	
	}
}
