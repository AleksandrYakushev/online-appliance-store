using OnlineApplianceStore.Business.Models.Input;
using OnlineApplianceStore.Business.Models.Output;
using OnlineApplianceStore.Data;
using System.Collections.Generic;

namespace OnlineApplianceStore.Business.Managers
{
    public interface IOrderManager
    {
        DataWrapper<OrderOutputModel> Merge(OrderInputModel inputModel);
        DataWrapper<OrderOutputModel> GetOrderById(long id);
        DataWrapper<List<OrderOutputModel>> GetAllOrders();
        DataWrapper<OrderOutputModel> DeleteOrderById(long id);
    }
}