using OnlineApplianceStore.Business.Models.Input;
using OnlineApplianceStore.Business.Models.Output;
using OnlineApplianceStore.Data;
using System.Collections.Generic;

namespace OnlineApplianceStore.Business.Managers
{
    public interface ICustomerManager
    {
        DataWrapper<CustomerOutputModel> DeleteCustomer(long id);
        DataWrapper<List<CustomerOutputModel>> GetAllCustomers();
        DataWrapper<CustomerOutputModel> GetCustomer(long id);
        DataWrapper<CustomerOutputModel> CreateCustomer(CustomerInputModel inputModel);
    }
}