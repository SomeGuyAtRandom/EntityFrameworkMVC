using System;
using System.Data.Entity;
using Web.Models;

namespace Web.ContextDbs.Builder
{
	// DropCreateDatabaseAlways 
	// DropCreateDatabaseIfModelChanges 

	public class MySqlSeeder :DropCreateDatabaseAlways <PeopleContext>
	{
		public MySqlSeeder ()
		{
		}

		public static DateTime GetRandomDate(DateTime from, DateTime to)
		{
			Random rnd = new Random ();
			var range = to - from;

			// NextDouble gives a number between 0.0 and 1.0
			var randTimeSpan = new TimeSpan((long)(rnd.NextDouble() * range.Ticks));

			return from + randTimeSpan;

		}

		// To use IDE code genrator to create overides use alt+insert
		protected override void Seed (PeopleContext context)
		{
			string[] FirstNames = {"Tom", "Dick", "Mary", "Jane", "Mark", "Nancy", "Bill", "Betty", "Rita", "Mick" };
			string[] LastNames = {"Smith", "Jones", "Anderson", "Sanders", "Cruz", "Washington", "Jefferson", "Nixon", "Carter", "Floyd" };
			DateTime start = new DateTime (1980,1,1);
			DateTime end = new DateTime (2000,1,1);

			for (int i = 0; i < LastNames.Length; i++) 
			{
				for (int j = 0; j < FirstNames.Length; j++) 
				{
					Person p = new Person (){
						FirstName = FirstNames[j],
						LastName = LastNames[i],
						BirthDate = GetRandomDate(start,end)
					};
					context.People.Add (p);
					context.SaveChanges ();
				}
			}

			base.Seed (context);
		}
	}
}

