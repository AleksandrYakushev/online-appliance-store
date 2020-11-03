using OnlineApplianceStore.Business.Models.Output;
using OnlineApplianceStore.Data.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineApplianceStore.Business.Models.Mappings
{
    public class AuthMapper
    {
        public AuthOutputModel ToOutputModel(CustomerDto customerDto)
        {
            if (customerDto == null)
            {
                return null;
            }
            return new AuthOutputModel()
            {
                Id = customerDto.Id,
                Phone = customerDto.Phone,
                Email = customerDto.Email,
                Password = customerDto.Password,
                RoleName = customerDto.Role.Name
            };
        }
    }
}
