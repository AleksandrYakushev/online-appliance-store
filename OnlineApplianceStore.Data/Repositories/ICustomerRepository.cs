using OnlineApplianceStore.Data.DTO;
using System.Collections.Generic;

namespace OnlineApplianceStore.Data.Repositories
{
    public interface ICustomerRepository
    {
        DataWrapper<CustomerDto> SelectCustomerById(long id);

        DataWrapper<List<CustomerDto>> SelectAllCustomers();
        DataWrapper<CustomerDto> DeleteCustomerById(long Id);

        DataWrapper<CustomerDto> CreateCustomer(CustomerDto customerDto);
    }
}