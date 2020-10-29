using OnlineApplianceStore.Business.Models.Input;
using OnlineApplianceStore.Business.Models.Output;
using OnlineApplianceStore.Data.DTO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace OnlineApplianceStore.Business.Models.Mappings
{
    public class CustomerMapper
    {
        public List<CustomerOutputModel> ToOutputModels(List<CustomerDto> customersDto)
        {
            List<CustomerOutputModel> customersModel = new List<CustomerOutputModel>();
            foreach(CustomerDto customerDto in customersDto)
            {
                customersModel.Add(ToOutputModel(customerDto));
            }
            return customersModel;

        }
        public CustomerOutputModel ToOutputModel(CustomerDto customerDto)
        {
            if (customerDto == null)
            {
                return null;
            }
            return new CustomerOutputModel
            {
                Id = customerDto.Id,
                Name = customerDto.Name,
                LastName = customerDto.LastName,
                Birthday = customerDto.Birthday.ToString("dd.MM.yyyy"),
                RegistrationDate = customerDto.RegistrationDate.ToString("dd.MM.yyyy HH.mm.ss"),
                LastUpdateDate = customerDto.LastUpdateDate.ToString("dd.MM.yyyy HH.mm.ss"),
                Address = customerDto.Address,
                Phone = customerDto.Phone,
                Email = customerDto.Email,
                RoleName = customerDto.Role.Name,
                CityName = customerDto.City.Name
            };

        }
        public CustomerDto ToDto(CustomerInputModel inputModel)
        {
            return new CustomerDto
            {
                Id = inputModel.Id,
                Name = inputModel.Name,
                LastName = inputModel.LastName,
                Birthday = DateTime.ParseExact(inputModel.Birthday, "dd.MM.yyyy", CultureInfo.InvariantCulture),
                Address = inputModel.Address,
                Phone = inputModel.Phone,
                Email = inputModel.Email,
                City = new CityDto() { Id = inputModel.CityId },

                Password = inputModel.Password,
            };


        }
    }
}
