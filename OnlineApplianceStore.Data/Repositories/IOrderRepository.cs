using OnlineApplianceStore.Data.DTO;
using System.Collections.Generic;

namespace OnlineApplianceStore.Data
{
    public interface IOrderRepository
    {
        DataWrapper<OrderDto> MergeOrder(OrderDto dto);
        DataWrapper<OrderDto> SelectOrderById(long orderId);
        DataWrapper<List<OrderDto>> SelectAllOrders();
        DataWrapper<OrderDto> DeleteOrderById(long orderId);
    }
}