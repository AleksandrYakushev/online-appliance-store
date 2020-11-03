using AutoMapper;
using OnlineApplianceStore.Business.Models.Input;
using OnlineApplianceStore.Business.Models.Output;
using OnlineApplianceStore.Data;
using OnlineApplianceStore.Data.DTO;
using OnlineApplianceStore.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineApplianceStore.Business.Managers
{
    public class CustomerManager : ICustomerManager
    {

        ICustomerRepository _customerRepository;
        IMapper _mapper;

        public CustomerManager(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        public DataWrapper<CustomerOutputModel> GetCustomer(long id)
        {
            var data = _customerRepository.SelectCustomerById(id);
            var mappedData = _mapper.Map<CustomerOutputModel>(data.Data);
            return new DataWrapper<CustomerOutputModel>()
            {
                Data = mappedData,
                ResultMessage = data.ResultMessage
            };
        }

        public DataWrapper<List<CustomerOutputModel>> GetAllCustomers()
        {
            var data = _customerRepository.SelectAllCustomers();
            var mappedData = _mapper.Map<List<CustomerOutputModel>>(data.Data);
            return new DataWrapper<List<CustomerOutputModel>>()
            {
                Data = mappedData,
                ResultMessage = data.ResultMessage
            };
        }

        public DataWrapper<CustomerOutputModel> CreateCustomer(CustomerInputModel inputModel)
        {
            var customerDto = _mapper.Map<CustomerDto>(inputModel);
            var data = _customerRepository.CreateCustomer(customerDto);
            var mappedData = _mapper.Map<CustomerOutputModel>(data.Data);
            return new DataWrapper<CustomerOutputModel>
            {
                Data = mappedData,
                ResultMessage = data.ResultMessage
            };
        }

        public DataWrapper<CustomerOutputModel> UpdateCustomer(CustomerInputModel inputModel)
        {
            var customerDto = _mapper.Map<CustomerDto>(inputModel);
            var data = _customerRepository.UpdateCustomer(customerDto);
            var mappedData = _mapper.Map<CustomerOutputModel>(data.Data);
            return new DataWrapper<CustomerOutputModel>
            {
                Data = mappedData,
                ResultMessage = data.ResultMessage
            };
        }

        public DataWrapper<CustomerOutputModel> DeleteCustomer(long id)
        {
            var data = _customerRepository.DeleteCustomerById(id);
            var mappedData = _mapper.Map<CustomerOutputModel>(data.Data);
            return new DataWrapper<CustomerOutputModel>()
            {
                Data = mappedData,
                ResultMessage = data.ResultMessage
            };
        }
    }
}