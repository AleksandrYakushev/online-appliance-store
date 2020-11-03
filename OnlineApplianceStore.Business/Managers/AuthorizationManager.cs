using AutoMapper;
using OnlineApplianceStore.Business.Models.Output;
using OnlineApplianceStore.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Business.Managers
{
    public class AuthManager
    {
        private ICustomerRepository _customerRepository;
        private IMapper _mapper;


        public AuthManager(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        public AuthOutputModel GetLeadByLogin(string login)
        {
            return null; //return _mapper.Map<AuthOutputModel>(_customerRepository.SelectLeadByLogin(login));
        }
    }
}