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

		public IBookShopDao BookShopDao
		{
			get { return db_dao; }
			set { db_dao = value; }
		}

		public bool Login(Model.Login login)
		{
			return db_dao.Login(login);
		}
		


	}
}
