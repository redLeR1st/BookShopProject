using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopDb.Model
{
	class Felhasznalo
	{
		public int u_id { get; set; }
		public bool torzsvasarlo { get; set; }
		public int tel_szam { get; set; }
		public string k_nev { get; set; }
		public string v_nev { get; set; }
		public int egyenleg { get; set; }
		public string email { get; set; }
		public int vasarolt_db { get; set; }
		public bool admine { get; set; }
	}
}
