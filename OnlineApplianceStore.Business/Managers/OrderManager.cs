using AutoMapper;
using OnlineApplianceStore.Business.Models.Input;
using OnlineApplianceStore.Business.Models.Output;
using OnlineApplianceStore.Data;
using OnlineApplianceStore.Data.DTO;
using System.Collections.Generic;

namespace OnlineApplianceStore.Business.Managers
{
    public class OrderManager : IOrderManager
    {
        private IOrderRepository _orderRepository;
        private IMapper _mapper;

        public OrderManager(IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        public DataWrapper<OrderOutputModel> Merge(OrderInputModel inputModel)
        {
            var customerDto = _mapper.Map<OrderDto>(inputModel);
            var data = _orderRepository.MergeOrder(customerDto);
            var mappedData = _mapper.Map<OrderOutputModel>(data.Data);
            return new DataWrapper<OrderOutputModel>
            {
                Data = mappedData,
                ResultMessage = data.ResultMessage
            };
        }

        public DataWrapper<OrderOutputModel> GetOrderById(long id)
        {
            var data = _orderRepository.SelectOrderById(id);
            var mappedData = _mapper.Map<OrderOutputModel>(data.Data);
            return new DataWrapper<OrderOutputModel>()
            {
                Data = mappedData,
                ResultMessage = data.ResultMessage
            };
        }

        public DataWrapper<List<OrderOutputModel>> GetAllOrders()
        {
            var data = _orderRepository.SelectAllOrders();
            var mappedData = _mapper.Map<List<OrderOutputModel>>(data.Data);
            return new DataWrapper<List<OrderOutputModel>>()
            {
                Data = mappedData,
                ResultMessage = data.ResultMessage
            };
        }

        public DataWrapper<OrderOutputModel> DeleteOrderById(long id)
        {
            var data = _orderRepository.DeleteOrderById(id);
            var mappedData = _mapper.Map<OrderOutputModel>(data.Data);
            return new DataWrapper<OrderOutputModel>()
            {
                Data = mappedData,
                ResultMessage = data.ResultMessage
            };
        }
    }
}
