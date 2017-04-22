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

	}
}
