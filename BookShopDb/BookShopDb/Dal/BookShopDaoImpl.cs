using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookShopDb.Model;
using Oracle.DataAccess.Client;
using System.Data;

namespace BookShopDb.Dal
{
	class BookShopDaoImpl : IBookShopDao
	{
		private static readonly string  db_connection = "Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 4000)))" +
			"(CONNECT_DATA = (SERVER = DEDICATED)(SID = kabinet))); User Id = h644771;" +
			"Password = harcos11;";

		public OracleConnection GetConnection()
		{
			using (OracleConnection conn = new OracleConnection(db_connection))
			{
			
				return conn;
			}
		}

		#region login
		public bool Login(Login login)
		{
			bool loginS = false;

			using (OracleConnection conn = new OracleConnection(db_connection))
			using (OracleCommand cmd = conn.CreateCommand())
			{
				conn.Open();

				cmd.CommandText = "SELECT * FROM login" +
					" WHERE username = @username AND pw = @pw";
				cmd.Parameters.Add("username", DbType.String).Value = login.Username;
				cmd.Parameters.Add("pw", DbType.String).Value = login.Pw;

				int rowCount = 0;
				OracleDataReader reader = cmd.ExecuteReader();

				while (reader.Read())
					rowCount++;
				if (rowCount == 1)
					loginS = true;
			}
				return loginS;
		}
		#endregion


	}
}
