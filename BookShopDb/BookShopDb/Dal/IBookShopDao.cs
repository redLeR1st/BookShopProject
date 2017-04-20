using BookShopDb.Model;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopDb.Dal
{
	interface IBookShopDao
	{
		OracleConnection GetConnection();

		bool Login(Login login);
	}
}
