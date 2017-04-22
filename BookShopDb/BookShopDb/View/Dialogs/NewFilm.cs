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
        }

        private void cancelFilmButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
