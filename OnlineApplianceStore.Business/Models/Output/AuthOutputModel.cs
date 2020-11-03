using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineApplianceStore.Business.Models.Output
{
    public class AuthOutputModel
    {
        public long? Id { get; set; }
        public string RoleName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
