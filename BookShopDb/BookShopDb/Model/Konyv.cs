using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopDb.Model
{
	class Konyv
	{
		public int t_id { get; set; }
		public int ar { get; set; }
		public string cim { get; set; }
		public string mufaj { get; set; }
		public int eladott_db { get; set; }
		public string szerzo { get; set; }
		public int ad_id { get; set; }
		public int ki_id { get; set; }
		public int kat_id { get; set; }
		public DateTime kiadasi_datum { get; set; }
		public int oldaszam { get; set; }
	}
}
