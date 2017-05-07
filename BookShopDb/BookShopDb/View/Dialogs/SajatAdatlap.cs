using BookShopDb.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.IO;
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

                label5.Text = felhasznalo.k_nev;
                label6.Text = felhasznalo.v_nev;
                label7.Text = felhasznalo.email;
                label8.Text = felhasznalo.tel_szam.ToString();
                label11.Text = felhasznalo.vasarolt_db.ToString();
				Egyenleglabel15.Text = felhasznalo.egyenleg.ToString();

				Utcalabel17.Text = bookShopApp.db_cont.GetLakhelyFromUid(felhasznalo.u_id).utca;
				Hszámlabel18.Text = bookShopApp.db_cont.GetLakhelyFromUid(felhasznalo.u_id).hazszam.ToString();




			if (felhasznalo.admine)
                {
                    label10.Text = "Admin";
                }
                else
                {
                    label10.Text = "Felhasználó";
                }

                if (felhasznalo.torzsvasarlo)
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

		private void label14_Click(object sender, EventArgs e)
		{

		}

		private void label15_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			new EddigVasaroltam(bookShopApp);
		}

        private void kepButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string pictureLocation = dialog.FileName.ToString();
                textBoxImagePath.Text = pictureLocation;
                pictureBox1.ImageLocation = pictureLocation;
            }
        }

        private void mentes_Click(object sender, EventArgs e)
        {
            string db_connection = "Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 4000)))" +
            "(CONNECT_DATA = (SERVER = DEDICATED)(SID = kabinet))); User Id = h667769;" +
            "Password = root";

            int u_id = bookShopApp.db_cont.GetOnlineFelhasznalo().u_id;

            using (OracleConnection conn = new OracleConnection(db_connection))
            using (OracleCommand cmnd = conn.CreateCommand())
            {
                FileStream fls;
                fls = new FileStream(this.textBoxImagePath.Text, FileMode.Open, FileAccess.Read);
                byte[] blob = new byte[fls.Length];
                fls.Read(blob, 0, System.Convert.ToInt32(fls.Length));
                fls.Close();

                conn.Open();

                cmnd.Parameters.Clear();
                cmnd.CommandText = "UPDATE felhasznalo SET kep = :BlobParameter" +
                " WHERE u_id = :u_id";

                cmnd.Parameters.Add("BlobParameter", OracleType.Blob).Value = blob;
                cmnd.Parameters.Add("u_id", OracleType.Number).Value = u_id;

                cmnd.ExecuteNonQuery();
                MessageBox.Show("Sikeres feltöltés");
            }
        }
    }
}
