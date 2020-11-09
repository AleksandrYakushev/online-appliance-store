using OnlineApplianceStore.Data.DTO;
using System.Collections.Generic;

namespace OnlineApplianceStore.Data.Repositories
{
    public interface ICustomerRepository
    {
        DataWrapper<CustomerDto> MergeCustomer(CustomerDto dto);
        DataWrapper<CustomerDto> SelectCustomerById(long id);

        DataWrapper<List<CustomerDto>> SelectAllCustomers();
        DataWrapper<CustomerDto> DeleteCustomerById(long Id);

    }
}