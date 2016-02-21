using System;
using System.Data.Entity;

namespace Web.ContextDbs.Builder
{
	public class MySqlConfiguration: DbConfiguration
	{
		public MySqlConfiguration ()
		{
			SetHistoryContext( "MySql.Data.MySqlClient", (conn, schema) => new MySqlHistoryContext(conn, schema));
		}
	}
}
