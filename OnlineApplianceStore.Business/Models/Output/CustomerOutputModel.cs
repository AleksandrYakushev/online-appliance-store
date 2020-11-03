using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineApplianceStore.Business.Models.Output
{
    public class CustomerOutputModel
    {
        public long? Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Birthday { get; set; }
        public string RegistrationDate { get; set; }
        public string LastUpdateDate { get; set; }
        public bool IsDeleted { get; set; }
        public string RoleName { get; set; }
        public string CityName { get; set; }
    }
}
