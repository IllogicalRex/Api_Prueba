using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.DTO
{
    public class PersonDTO
    {
		public int IdPerson { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime BirthDate { get; set; }
		public DateTime CreationDate { get; set; }
		public int RoleId { get; set; }

	}
}
