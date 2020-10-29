using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineApplianceStore.Data.DTO
{
    public class CustomerDto
	{
		public long? Id { get; set; }
		public string Name { get; set; }
		public string LastName { get; set; }
		public DateTime Birthday { get; set; }
		public DateTime RegistrationDate { get; set; }
		public DateTime LastUpdateDate { get; set; }
		public string Address { get; set; }
		public string Phone { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public bool isDeleted { get; set; }
		public RoleDto Role { get; set; }
		public CityDto City { get; set; }
	}
}
