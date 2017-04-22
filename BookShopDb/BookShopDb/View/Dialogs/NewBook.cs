
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
        }

        private void cancelBookButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
