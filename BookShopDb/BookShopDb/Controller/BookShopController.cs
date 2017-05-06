using BookShopDb.Dal;
using BookShopDb.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopDb.Controller
{
	class BookShopController
	{
		private IBookShopDao db_dao = new BookShopDaoImpl();


		public Felhasznalo GetOnlineFelhasznalo()
		{
			if (db_dao.OnlineFelhasznalo != null)
				db_dao.onlineFelhasznaloRefresh();
			return db_dao.OnlineFelhasznalo;
		}

		public IBookShopDao BookShopDao
		{
			get { return db_dao; }
			set { db_dao = value; }
		}

		public bool Login(Model.Login login)
		{
			return db_dao.Login(login);
		}
		
		public IEnumerable<Konyv> GetKonyvekFromCheapest()
		{
			return db_dao.GetKonyvek().OrderBy(o=>o.ar).ToList();
		}

		public IEnumerable<Konyv> GetKonyvekFromMostPopular()
		{
			return db_dao.GetKonyvek().OrderByDescending(o => o.eladott_db).ToList();
		}
		public string[] GetCategoria()
		{
			return db_dao.GetCategoria();
		}

		public bool NewBook(Tetel tetel, int oldalszam)
		{
			return db_dao.NewBook(tetel, oldalszam);
		}

        public bool NewShop(Aruhaz aruhaz)
        {
            return db_dao.NewShop(aruhaz);
        }

        public int GetCategoriaIdByName(string kat_nev)
		{
			return db_dao.GetCategoriaIdByName(kat_nev);
		}

		public IEnumerable<Film> GetFilmek()
		{
			return db_dao.GetFilmek();
		}
		public bool NewFilm(Tetel tetel, int hossz)
		{
			return db_dao.NewFilm(tetel, hossz);
		}

		public IEnumerable<Zene> GetZenek()
		{
			return db_dao.GetZene();
		}
		public bool NewZene(Tetel tetel, int hossz)
		{
			return db_dao.NewZene(tetel, hossz);
		}
		public Adatlap GetAdatlapById(Tetel tetel)
		{
			return db_dao.GetAdatlapById(tetel);
		}
        public bool Megveszem(Vasarol vasarol)
        {
            return db_dao.Megveszem(vasarol);
        }
		public Lakik GetLakhelyFromUid(int u_id)
		{
			return db_dao.SelectLakhelyFromUid(u_id);
		}

		public Tetel GetTetelFromTid(int t_id)
		{
			return db_dao.SelectTetelFromTid(t_id);
		}

		public IEnumerable<MegvettKonyvek> GetMegvettKonyvek(int u_id)
		{
			return db_dao.GetMegvettKonyvek(u_id);
		}
	
		public IEnumerable<MegvettFilmek> GetMegvettFilmek(int u_id)
		{
			return db_dao.GetMegvettFilmek(u_id);
		}

		public IEnumerable<MegvettZenek> GetMegvettZenek(int u_id)
		{
			return db_dao.GetMegvettZenek(u_id);
		}


	}
}
