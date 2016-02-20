using System;
using System.Data.Common;
using System.Data.Entity;
using Web.Models;
//using MySql.Data.Entity;


namespace Web.ContextDbs
{
	public class PeopleContext : DbContext 
	{
		public PeopleContext ()  : base("connStr")
		{
		}

		public PeopleContext (DbConnection existingConnection, bool contextOwnsConnection)
			: base(existingConnection, contextOwnsConnection)
		{

		}

		public DbSet <Person> People { get; set;}
	}
}

