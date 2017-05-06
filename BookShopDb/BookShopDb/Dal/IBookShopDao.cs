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
		bool NewBook(Tetel tetel, int oldalszam);
		Felhasznalo GetFelhasznaloFromUname(string uname);
		IEnumerable<Konyv> GetKonyvek();
		string[] GetCategoria();
		int GetCategoriaIdByName(string kat_nev);
		IEnumerable<Film> GetFilmek();
		bool NewFilm(Tetel tetel, int hossz);
		IEnumerable<Zene> GetZene();
		bool NewZene(Tetel tetel, int hossz);
		Adatlap GetAdatlapById(Tetel tetel);
        bool NewShop(Aruhaz aruhaz);
        bool Megveszem(Vasarol vasarol);
		void onlineFelhasznaloRefresh();
		Lakik SelectLakhelyFromUid(int u_id);
		Tetel SelectTetelFromTid(int t_id);
		IEnumerable<MegvettKonyvek> GetMegvettKonyvek(int u_id);
		IEnumerable<MegvettFilmek> GetMegvettFilmek(int u_id);
		IEnumerable<MegvettZenek> GetMegvettZenek(int u_id);
	}
}
