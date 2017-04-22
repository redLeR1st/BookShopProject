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
		Felhasznalo OnlineFelhasznalo { get; set; }

		OracleConnection GetConnection();
		bool Login(Model.Login login);
		bool NewBook(Konyv book);
		Felhasznalo GetFelhasznaloFromUname(string uname);
		IEnumerable<Konyv> GetKonyvek();
	}
}
