
using BookShopDb.Model;
using System;
using System.Windows.Forms;

namespace BookShopDb.View
{
    partial class NewBook : Form
    {
        private BookShopApp bookShopApp;

        public NewBook(BookShopApp bookShopApp)
        {
            InitializeComponent();

            this.bookShopApp = bookShopApp;
			mufajcomboBox1.Items.AddRange(new object[] {"Horror", "Scifi", "Komédia", "Dráma"});
			categoriacomboBox1.Items.AddRange(bookShopApp.db_cont.GetCategoria());
        }

        private void cancelBookButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

		private void addBookButton_Click(object sender, System.EventArgs e)
		{
			Tetel temp = new Tetel
			{
				cim = titleBookTextBox.Text,
				szerzo = authorBookTextBox.Text,
				mufaj = (string)mufajcomboBox1.SelectedItem,
				kiadasi_datum = releaseBookDateTimePicker.Value,
				kat_id = bookShopApp.db_cont.GetCategoriaIdByName((string)categoriacomboBox1.SelectedItem),
				ar = Convert.ToInt32(priceBookTextBox.Text),
				
				eladott_db = 0,
			};
			if (bookShopApp.db_cont.NewBook(temp, Convert.ToInt32(pageNumbernumericUpDown1.Value)))
				MessageBox.Show("Sikerült a könyv hozzáadása");
			else
				MessageBox.Show("Nem sikerült a könyv hozzáadása");
		}

		private void NewBook_Load(object sender, EventArgs e)
		{

		}

        private void titleBookTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
