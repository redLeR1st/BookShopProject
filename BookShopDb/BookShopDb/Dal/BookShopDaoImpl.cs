using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookShopDb.Model;
using Oracle.DataAccess.Client;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace BookShopDb.Dal
{
	class BookShopDaoImpl : IBookShopDao
	{
		/*
			using (OracleConnection conn = new OracleConnection(db_connection))
			using (OracleCommand cmd = conn.CreateCommand())
			{
				conn.Open(); 




			}

		*/
		private static readonly string db_connection = "Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 4000)))" +
			"(CONNECT_DATA = (SERVER = DEDICATED)(SID = kabinet))); User Id = h644771;" +
			"Password = harcos11;";

		public Felhasznalo OnlineFelhasznalo { get; set; } = null;

		public List<Konyv> Konyvek{ get;  set;} 

		public OracleConnection GetConnection()
		{
			using (OracleConnection conn = new OracleConnection(db_connection))
			{
			
				return conn;
			}
		}

		#region segedFg
		public Felhasznalo GetFelhasznaloFromUname(string uname)
		{
			Felhasznalo temp = null;

			using (OracleConnection conn = new OracleConnection(db_connection))
			using (OracleCommand cmd = conn.CreateCommand())
			{
				conn.Open();
				
				cmd.CommandText = "SELECT * FROM felhasznalo, " +
					"login WHERE felhasznalo.u_id = login.u_id AND " +
					 "login.username = :username";

				cmd.Parameters.Add("username", uname);

				OracleDataReader reader = cmd.ExecuteReader();

				while (reader.Read())
				{
					Felhasznalo temp2 = new Felhasznalo
					{
						u_id = reader.GetInt32(reader.GetOrdinal("u_id")),
						torzsvasarlo = reader.GetInt32(reader.GetOrdinal("torzsvasarlo")) == 1 ? true : false,
						tel_szam = reader.GetInt32(reader.GetOrdinal("tel_szam")),
						k_nev = reader.GetString(reader.GetOrdinal("k_nev")),
						v_nev = reader.GetString(reader.GetOrdinal("v_nev")),
						email = reader.GetString(reader.GetOrdinal("email")),
						vasarolt_db = reader.GetInt32(reader.GetOrdinal("vasarolt_db")),
						admine = reader.GetInt32(reader.GetOrdinal("admine")) == 1 ? true : false,
					};
					
					temp = temp2;
				}

			}
				return temp;
		}
		#endregion

		#region newBook
		public bool NewBook(Konyv book)
		{
			throw new NotImplementedException();
			bool rvS = false;

			using (OracleConnection conn = new OracleConnection(db_connection))
			using (OracleCommand cmd = conn.CreateCommand())
			{
				cmd.CommandText = "INSERT INTO konyv ()";



			}

			return rvS;
		}
		#endregion

		#region login
		public bool Login(Model.Login login)
		{
			bool loginS = false;

			using (OracleConnection conn = new OracleConnection(db_connection))
			using (OracleCommand cmd = conn.CreateCommand())
			{
				conn.Open();

				cmd.CommandText = "SELECT * FROM login" +
					" WHERE username = :username AND pw = :pw";
				cmd.Parameters.Add("username", login.Username);
				cmd.Parameters.Add("pw", login.Pw);

				int rowCount = 0;
				OracleDataReader reader = cmd.ExecuteReader();

				while (reader.Read())
					rowCount++;
				if (rowCount == 1)
				{
					loginS = true;
					OnlineFelhasznalo = GetFelhasznaloFromUname(login.Username);
				}
			}
				return loginS;
		}
		#endregion

		#region getKonyvek
		public IEnumerable<Konyv> GetKonyvek()
		{
			Konyvek = new List<Konyv>();
			using (OracleConnection conn = new OracleConnection(db_connection))
			using (OracleCommand cmd = conn.CreateCommand())
			{
				conn.Open();

				cmd.CommandText = "SELECT * FROM tetel,konyv WHERE tetel.t_id = konyv.t_id";

				OracleDataReader reader = cmd.ExecuteReader();
				
				while (reader.Read())
				{	
					Konyv temp = new Konyv
					{
						t_id = reader.GetInt32(reader.GetOrdinal("t_id")),
						ar = reader.GetInt32(reader.GetOrdinal("ar")),
						cim = reader.GetString(reader.GetOrdinal("cim")),
						mufaj = reader.GetString(reader.GetOrdinal("mufaj")),
						eladott_db = reader.GetInt32(reader.GetOrdinal("eladott_db")),
						szerzo = reader.GetString(reader.GetOrdinal("szerzo")),
						ad_id = reader.GetInt32(reader.GetOrdinal("ad_id")),
						ki_id = reader.GetInt32(reader.GetOrdinal("ki_id")),
						kat_id = reader.GetInt32(reader.GetOrdinal("kat_id")),
						kiadasi_datum = DateTime.ParseExact(reader.GetDateTime(reader.GetOrdinal("kiadasi_datum")).ToString("yyyy-MM-dd"), "yyyy-MM-dd", CultureInfo.InvariantCulture),
						oldaszam = reader.GetInt32(reader.GetOrdinal("oldalszam"))
					};

					Konyvek.Add(temp);

				}

			}

			return Konyvek;
		}
		#endregion


	}
}
