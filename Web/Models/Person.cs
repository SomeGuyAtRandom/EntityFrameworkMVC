using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.Models
{

	[Table("people")]
	public class Person
	{
		public Person ()
		{
		}

		[Column("id")]
		public int Id { get; set; }

		[Column("first_name")]
		[Required(ErrorMessage = "First name is required")]
		public string FirstName { get; set; }

		[Column("last_name")]
		[Required(ErrorMessage = "Last name is required")]
		public string LastName { get; set; }

		// Will be added in a future video
		//public string PhoneNumber { get; set; }

		[Column("birth_date")]
		[Required(ErrorMessage = "Birthday is required")]
		public DateTime? BirthDate { get; set; }

	}
}

