using OnlineApplianceStore.Business.Models.Input;
using OnlineApplianceStore.Business.Models.Output;
using OnlineApplianceStore.Data;
using System.Collections.Generic;

namespace OnlineApplianceStore.Business.Managers
{
    public interface ICustomerManager
    {
        public DataWrapper<CustomerOutputModel> Merge(CustomerInputModel inputModel);
        DataWrapper<CustomerOutputModel> GetCustomer(long id);
        DataWrapper<List<CustomerOutputModel>> GetAllCustomers();
        DataWrapper<CustomerOutputModel> DeleteCustomer(long id);
    }
}