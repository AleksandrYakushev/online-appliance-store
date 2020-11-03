//using OnlineApplianceStore.Business.Models.Input;
//using OnlineApplianceStore.Business.Models.Output;
//using OnlineApplianceStore.Data.DTO;
//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;

//namespace OnlineApplianceStore.Business.Models.Mappings
//{
//    public class CustomerMapper : ICustomerMapper
//    {
//        private const string _shortDateFormat = "dd.mm.yyyy";
//        private const string _longDateFormat = "dd.MM.yyyy HH:mm:ss";
//        public List<CustomerOutputModel> ToOutputModels(List<CustomerDto> customersDto)
//        {
//            List<CustomerOutputModel> customersModel = new List<CustomerOutputModel>();
//            foreach (CustomerDto customerDto in customersDto)
//            {
//                customersModel.Add(ToOutputModel(customerDto));
//            }
//            return customersModel;

//        }
//        public CustomerOutputModel ToOutputModel(CustomerDto customerDto)
//        {
//            return new CustomerOutputModel
//            {
//                Id = customerDto.Id,
//                Name = customerDto.Name,
//                LastName = customerDto.LastName,
//                Birthday = customerDto.Birthday.ToString(_shortDateFormat),
//                RegistrationDate = customerDto.RegistrationDate.ToString(_longDateFormat),
//                LastUpdateDate = customerDto.LastUpdateDate.ToString(_longDateFormat),
//                Address = customerDto.Address,
//                Phone = customerDto.Phone,
//                Email = customerDto.Email,
//                RoleName = customerDto.Role.Name,
//                CityName = customerDto.City.Name
//            };

//        }
//        public CustomerDto ToDto(CustomerInputModel inputModel)
//        {
            
//            return new CustomerDto
//            {
//                Id = inputModel.Id,
//                Name = inputModel.Name,
//                LastName = inputModel.LastName,
//                Birthday = DateTime.ParseExact(inputModel.Birthday, _shortDateFormat, CultureInfo.InvariantCulture),
//                Address = inputModel.Address,
//                Phone = inputModel.Phone,
//                Email = inputModel.Email,
//                Password = inputModel.Password,
//                City = new CityDto() { Id = inputModel.CityId }
//            };


//        }
//    }
//}
