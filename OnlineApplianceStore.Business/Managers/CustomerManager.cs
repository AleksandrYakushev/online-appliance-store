using OnlineApplianceStore.Business.Models.Input;
using OnlineApplianceStore.Business.Models.Mappings;
using OnlineApplianceStore.Business.Models.Output;
using OnlineApplianceStore.Data;
using OnlineApplianceStore.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineApplianceStore.Business.Managers
{
    public class CustomerManager : ICustomerManager
    {

        ICustomerRepository _customerRepository;
        CustomerMapper _mapper = new CustomerMapper();

        public DataWrapper<CustomerOutputModel> GetCustomer(long id)
        {
            var data = _customerRepository.SelectCustomerById(id);
            var mappedData = _mapper.ToOutputModel(data.Data);
            return new DataWrapper<CustomerOutputModel>()
            {
                Data = mappedData,
                ResultMessage = data.ResultMessage
            };
        }

        public DataWrapper<List<CustomerOutputModel>> GetAllCustomers()
        {
            var data = _customerRepository.SelectAllCustomers();
            var mappedData = _mapper.ToOutputModels(data.Data);
            return new DataWrapper<List<CustomerOutputModel>>()
            {
                Data = mappedData,
                ResultMessage = data.ResultMessage
            };
        }

        public DataWrapper<CustomerOutputModel> DeleteCustomer(long id)
        {
            var data = _customerRepository.DeleteCustomerById(id);
            var mappedData = _mapper.ToOutputModel(data.Data);
            return new DataWrapper<CustomerOutputModel>()
            {
                Data = mappedData,
                ResultMessage = data.ResultMessage
            };
        }

        public DataWrapper<CustomerOutputModel> CreateCustomer(CustomerInputModel inputModel)
        {
            return null;
        }
    }
}