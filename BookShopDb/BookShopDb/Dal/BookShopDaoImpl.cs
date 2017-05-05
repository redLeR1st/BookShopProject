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
		#region Propertyk
		private static readonly string db_connection = "Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 4000)))" +
			"(CONNECT_DATA = (SERVER = DEDICATED)(SID = kabinet))); User Id = h667769;" +
			"Password = jelszo";

		public Felhasznalo OnlineFelhasznalo { get; set; } = null;

		public List<Konyv> Konyvek { get; set; }
		public List<Film> Filmek { get; set; }
		public List<Zene> Zenek { get; set; }
		public OracleConnection GetConnection()
		{
			using (OracleConnection conn = new OracleConnection(db_connection))
			{

				return conn;
			}
		}
		#endregion

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

		public string[] GetCategoria()
		{
			int length = 0;

			List<Kategoria> kategoriak = new List<Kategoria>();

			using (OracleConnection conn = new OracleConnection(db_connection))
			using (OracleCommand cmd = conn.CreateCommand())
			{
				conn.Open();

				cmd.CommandText = "SELECT * FROM kategoria";

				OracleDataReader reader = cmd.ExecuteReader();

				while (reader.Read())
				{
					Kategoria temp = new Kategoria
					{
						kat_id = reader.GetInt32(reader.GetOrdinal("kat_id")),
						nev = reader.GetString(reader.GetOrdinal("nev"))
					};
					kategoriak.Add(temp);
				}
				length = kategoriak.Count();

			}
			int i = 0;
			Kategoria[] aarray = new Kategoria[length];
			string[] nev = new string[length];
			foreach (Kategoria temp in kategoriak)
			{
				aarray[i] = temp;
				nev[i] = temp.nev;
				i++;
			}


			return nev;

		}

		public int GetCategoriaIdByName(string kat_nev)
		{
			int id = -1;

			using (OracleConnection conn = new OracleConnection(db_connection))
			using (OracleCommand cmd = conn.CreateCommand())
			{
				conn.Open();

				cmd.CommandText = "SELECT * FROM kategoria " +
					"WHERE nev = :nev";

				cmd.Parameters.Add("nev", kat_nev);

				OracleDataReader reader = cmd.ExecuteReader();

				if (reader.Read())
				{
					id = reader.GetInt32(reader.GetOrdinal("kat_id"));
				}

			}

			return id;
		}


		private int? AddNewAdatlap()
		{
			int? NewAdtalapId = null;

			using (OracleConnection conn = new OracleConnection(db_connection))
			using (OracleCommand cmd = conn.CreateCommand())
			{
				conn.Open();

				cmd.CommandText = "INSERT INTO adatlap (KOMMENT, ERTEKELES, LEIRAS) VALUES('DEMO-ertekeles', 4, 'DEMO-leiras')";

				int rowAff = cmd.ExecuteNonQuery();

				if (rowAff == 1)
					NewAdtalapId = GetNewAdatlapId();
				
			}

			return NewAdtalapId;
		}

		private int? GetNewAdatlapId()
		{
			int? newid = null;

			using (OracleConnection conn = new OracleConnection(db_connection))
			using (OracleCommand cmd = conn.CreateCommand())
			{
				conn.Open();

				cmd.CommandText = "SELECT * FROM adatlap ORDER BY ad_id";

				OracleDataReader reader = cmd.ExecuteReader();

				while (reader.Read())
				{
					newid = reader.GetInt32(reader.GetOrdinal("ad_id"));
				}
				
			}
			return newid;
		}
		private bool InsertOldalszam(int oldalszam)
		{
			bool rvS = false;
			using (OracleConnection conn = new OracleConnection(db_connection))
			using (OracleCommand cmd = conn.CreateCommand())

			{
				conn.Open();
				cmd.CommandText = "INSERT INTO konyv (t_id, oldalszam) VALUES(:t_id, :oldalszam)";
				cmd.Parameters.Add("t_id", GetNewTetelId());
				cmd.Parameters.Add("oldalszam", oldalszam);

				rvS = cmd.ExecuteNonQuery() == 1 ? true : false;
 
			}

			return rvS;
		}

		private bool InsertHossz(int hossz)
		{
			bool rvS = false;
			using (OracleConnection conn = new OracleConnection(db_connection))
			using (OracleCommand cmd = conn.CreateCommand())

			{
				conn.Open();
				cmd.CommandText = "INSERT INTO film (t_id, hossz) VALUES(:t_id, :hossz)";
				cmd.Parameters.Add("t_id", GetNewTetelId());
				cmd.Parameters.Add("hossz", hossz);

				rvS = cmd.ExecuteNonQuery() == 1 ? true : false;

			}

			return rvS;
		}

		private bool InsertZeneHossz(int hossz)
		{
			bool rvS = false;
			using (OracleConnection conn = new OracleConnection(db_connection))
			using (OracleCommand cmd = conn.CreateCommand())

			{
				conn.Open();
				cmd.CommandText = "INSERT INTO zene (t_id, hossz) VALUES(:t_id, :hossz)";
				cmd.Parameters.Add("t_id", GetNewTetelId());
				cmd.Parameters.Add("hossz", hossz);

				rvS = cmd.ExecuteNonQuery() == 1 ? true : false;

			}

			return rvS;
		}

		private int GetNewTetelId()
		{
			int newid = -1;

			using (OracleConnection conn = new OracleConnection(db_connection))
			using (OracleCommand cmd = conn.CreateCommand())
			{
				conn.Open();

				cmd.CommandText = "SELECT * FROM tetel ORDER BY t_id";

				OracleDataReader reader = cmd.ExecuteReader();

				while (reader.Read())
				{
					newid = reader.GetInt32(reader.GetOrdinal("t_id"));
				}

			}
			return newid;

		}

		#endregion

		#region newKonyvek
		public bool NewBook(Tetel tetel, int oldalszam)
		{

			bool rvS = false;

			using (OracleConnection conn = new OracleConnection(db_connection))
			using (OracleCommand cmd = conn.CreateCommand())
			
			{
				conn.Open();
				cmd.CommandText = "INSERT INTO tetel (ar, cim, mufaj, eladott_db, szerzo, ad_id, ki_id, kiadasi_datum, kat_id) " +
					"VALUES(:ar, :cim, :mufaj, :eladott_db, :szerzo, :ad_id, :ki_id, :kiadasi_datum, :kat_id)";

				cmd.Parameters.Add("ar", tetel.ar);
				cmd.Parameters.Add("cim", tetel.cim);
				cmd.Parameters.Add("mufaj", tetel.mufaj);
				cmd.Parameters.Add("eladott_db", tetel.eladott_db);
				cmd.Parameters.Add("szerzo", tetel.szerzo);
				cmd.Parameters.Add("ad_id", AddNewAdatlap());
				cmd.Parameters.Add("ki_id", 4);
				cmd.Parameters.Add("kiadasi_datum", tetel.kiadasi_datum);
				cmd.Parameters.Add("kat_id", tetel.kat_id);

				rvS = cmd.ExecuteNonQuery()==1?true:false;

				if (rvS)
					if (!InsertOldalszam(oldalszam))
						rvS = false;
			}

			return rvS;
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

		#region newFilemek
		public bool NewFilm(Tetel tetel, int hossz)
		{
			bool rvS = false;

			using (OracleConnection conn = new OracleConnection(db_connection))
			using (OracleCommand cmd = conn.CreateCommand())

			{
				conn.Open();
				cmd.CommandText = "INSERT INTO tetel (ar, cim, mufaj, eladott_db, szerzo, ad_id, ki_id, kiadasi_datum, kat_id) " +
					"VALUES(:ar, :cim, :mufaj, :eladott_db, :szerzo, :ad_id, :ki_id, :kiadasi_datum, :kat_id)";

				cmd.Parameters.Add("ar", tetel.ar);
				cmd.Parameters.Add("cim", tetel.cim);
				cmd.Parameters.Add("mufaj", tetel.mufaj);
				cmd.Parameters.Add("eladott_db", tetel.eladott_db);
				cmd.Parameters.Add("szerzo", tetel.szerzo);
				cmd.Parameters.Add("ad_id", AddNewAdatlap());
				cmd.Parameters.Add("ki_id", 4);
				cmd.Parameters.Add("kiadasi_datum", tetel.kiadasi_datum);
				cmd.Parameters.Add("kat_id", tetel.kat_id);

				rvS = cmd.ExecuteNonQuery() == 1 ? true : false;

				if (rvS)
					if (!InsertHossz(hossz))
						rvS = false;
			}

			return rvS;
		}
		#endregion

		#region getFilmek
		public IEnumerable<Film> GetFilmek()
		{
			Filmek = new List<Film>();
			using (OracleConnection conn = new OracleConnection(db_connection))
			using (OracleCommand cmd = conn.CreateCommand())
			{
				conn.Open();

				cmd.CommandText = "SELECT * FROM tetel,film WHERE tetel.t_id = film.t_id";

				OracleDataReader reader = cmd.ExecuteReader();

				while (reader.Read())
				{
					Film temp = new Film
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
						hossz = reader.GetInt32(reader.GetOrdinal("hossz"))
					};

					Filmek.Add(temp);

				}

			}

			return Filmek;
		}
		#endregion

		#region newZenek
		public bool NewZene(Tetel tetel, int hossz)
		{
			bool rvS = false;

			using (OracleConnection conn = new OracleConnection(db_connection))
			using (OracleCommand cmd = conn.CreateCommand())

			{
				conn.Open();
				cmd.CommandText = "INSERT INTO tetel (ar, cim, mufaj, eladott_db, szerzo, ad_id, ki_id, kiadasi_datum, kat_id) " +
					"VALUES(:ar, :cim, :mufaj, :eladott_db, :szerzo, :ad_id, :ki_id, :kiadasi_datum, :kat_id)";

				cmd.Parameters.Add("ar", tetel.ar);
				cmd.Parameters.Add("cim", tetel.cim);
				cmd.Parameters.Add("mufaj", tetel.mufaj);
				cmd.Parameters.Add("eladott_db", tetel.eladott_db);
				cmd.Parameters.Add("szerzo", tetel.szerzo);
				cmd.Parameters.Add("ad_id", AddNewAdatlap());
				cmd.Parameters.Add("ki_id", 4);
				cmd.Parameters.Add("kiadasi_datum", tetel.kiadasi_datum);
				cmd.Parameters.Add("kat_id", tetel.kat_id);

				rvS = cmd.ExecuteNonQuery() == 1 ? true : false;

				if (rvS)
					if (!InsertZeneHossz(hossz))
						rvS = false;
			}

			return rvS;
		}
		#endregion

		#region getZenek
		public IEnumerable<Zene> GetZene()
		{
			Zenek = new List<Zene>();
			using (OracleConnection conn = new OracleConnection(db_connection))
			using (OracleCommand cmd = conn.CreateCommand())
			{
				conn.Open();

				cmd.CommandText = "SELECT * FROM tetel,zene WHERE tetel.t_id = zene.t_id";

				OracleDataReader reader = cmd.ExecuteReader();

				while (reader.Read())
				{
					Zene temp = new Zene
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
						hossz = reader.GetInt32(reader.GetOrdinal("hossz"))
					};

					Zenek.Add(temp);

				}

			}

			return Zenek;
		}
		#endregion

		#region getAdatlap
		public Adatlap GetAdatlapById(Tetel tetel)
		{
			Adatlap adatlap = null;

			using (OracleConnection conn = new OracleConnection(db_connection))
			using (OracleCommand cmd = conn.CreateCommand())
			{
				conn.Open();

				cmd.CommandText = "SELECT * FROM adatlap WHERE ad_id = :ad_id";
				cmd.Parameters.Add("ad_id", tetel.ad_id);

				OracleDataReader reader = cmd.ExecuteReader();

				while(reader.Read())
				{
					Adatlap temp = new Adatlap
					{
						ad_id = reader.GetInt32(reader.GetOrdinal("ad_id")),
						komment = reader.GetString(reader.GetOrdinal("komment")),
						ertekels = reader.GetInt32(reader.GetOrdinal("ertekeles")),
						leiras = reader.GetString(reader.GetOrdinal("leiras"))
					};
					adatlap = temp;
				}
			}
			return adatlap;
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

        #region newAruhazak
        public bool NewShop(Aruhaz aruhaz)
        {

            bool rvS = false;

            using (OracleConnection conn = new OracleConnection(db_connection))
            using (OracleCommand cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = "INSERT INTO aruhaz (nev, cim) " +
                    "VALUES(:nev, :cim)";

                cmd.Parameters.Add("nev", aruhaz.nev);
                cmd.Parameters.Add("cim", aruhaz.cim);

                rvS = cmd.ExecuteNonQuery() == 1 ? true : false;
            }

            return rvS;
        }

        #endregion

        #region Megveszem
        public bool Megveszem(Vasarol vasarol)
        {

            bool rvS = false;

            using (OracleConnection conn = new OracleConnection(db_connection))
            using (OracleCommand cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = "INSERT INTO vasarol (v_id, u_id, t_id) " +
                    "VALUES(:v_id, :u_id, :t_id)";

                cmd.Parameters.Add("v_id", vasarol.v_id);
                cmd.Parameters.Add("u_id", vasarol.u_id);
                cmd.Parameters.Add("t_id", vasarol.t_id);

                rvS = cmd.ExecuteNonQuery() == 1 ? true : false;
            }

            return rvS;
        }

        #endregion
    }
}