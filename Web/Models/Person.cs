using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.Models
{
	public class PersonConfig
	{
		[Display(Name = "First Name")]
		public string FirstName { get; set; }

		[Display(Name = "Last Name")]
		public string LastName { get; set; }

		[Display(Name = "Birthday")]
		public DateTime? BirthDate { get; set; }
	}

	[MetadataType(typeof(PersonConfig))]
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

		public string PhoneNumber { get; set; }

		[Column("birth_date")]
		[Required(ErrorMessage = "Birthday is required")]
		public DateTime? BirthDate { get; set; }

	}
}

