using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineApplianceStore.Business.Models.Input
{
    public class CustomerInputModel
    {
		public long? Id { get; set; }
		public string Name { get; set; }
		public string LastName { get; set; }
		public string Birthday { get; set; }
		public string Address { get; set; }
		public string Phone { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public int CityId { get; set; }
		public int RoleId { get; set; }
	}
}
