using Dapper;
using Microsoft.Extensions.Options;
using OnlineApplianceStore.Core;
using OnlineApplianceStore.Data.DTO;
using OnlineApplianceStore.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace OnlineApplianceStore.Data
{
    public class OrderRepository : BaseRepository, IOrderRepository
    {
        public OrderRepository(IOptions<DBSettings> options)
        {
            DbConnection = new SqlConnection(options.Value.ConnectionString);
        }

        public DataWrapper<OrderDto> MergeOrder(OrderDto dto)
        {
            var data = new DataWrapper<OrderDto>();
            try
            {
                data.Data = DbConnection.Query<OrderDto, CustomerDto, ProductDto, PaymentTypeDto, OrderDto>(
                    StoredProcedure.MergeOrderProcedure,
                    (order, customer, product, paymentType) =>
                    {
                        order.Customer = customer;
                        order.Product = product;
                        order.PaymentType = paymentType;
                        return order;
                    },
                    new
                    {
                        dto.Id,
                        ProductId = dto.Product.Id,
                        CustomerId = dto.Customer.Id,
                        PaymentTypeId = dto.PaymentType.Id,
                        dto.TotalAmount,
                        dto.OperationDate
                    },
                    splitOn: "Id",
                    commandType: CommandType.StoredProcedure
                    ).SingleOrDefault();
            }
            catch (Exception ex)
            {
                data.ResultMessage = ex.Message;
            }
            return data;
        }

        public DataWrapper<OrderDto> SelectOrderById(long orderId)
        {
            var data = new DataWrapper<OrderDto>();
            try
            {
                data.Data = DbConnection.Query<OrderDto, CustomerDto, ProductDto, PaymentTypeDto, OrderDto>(
                StoredProcedure.SelectProductProcedure,
                (order, customer, product, paymentType) =>
                {
                    order.Customer = customer;
                    order.Product = product;
                    order.PaymentType = paymentType;
                    return order;
                },
                new
                { orderId },
                splitOn: "Id",
                commandType: CommandType.StoredProcedure
                ).SingleOrDefault();
            }
            catch (Exception ex)
            {
                data.ResultMessage = ex.Message;
            }
            return data;
        }

        public DataWrapper<List<OrderDto>> SelectAllOrders()
        {
            var data = new DataWrapper<List<OrderDto>>();
            try
            {
                data.Data = DbConnection.Query<OrderDto, CustomerDto, ProductDto, PaymentTypeDto, OrderDto>(
                    StoredProcedure.SelectAllOrdersProcedure,
                    (order, customer, product, paymentType) =>
                    {
                        order.Customer = customer;
                        order.Product = product;
                        order.PaymentType = paymentType;
                        return order;
                    },
                    splitOn: "Id",
                    commandType: CommandType.StoredProcedure
                    ).ToList();
            }
            catch (Exception ex)
            {
                data.ResultMessage = ex.Message;
            }

            return data;
        }

        public DataWrapper<OrderDto> DeleteOrderById(long orderId)
        {
            var data = new DataWrapper<OrderDto>();
            try
            {
                data.Data = DbConnection.Query<OrderDto, CustomerDto, ProductDto, PaymentTypeDto, OrderDto>(
                    StoredProcedure.DeleteOrderProcedure,
                    (order, customer, product, paymentType) =>
                    {
                        order.Customer = customer;
                        order.Product = product;
                        order.PaymentType = paymentType;
                        return order;
                    },
                    new { orderId },
                    splitOn: "Id",
                    commandType: CommandType.StoredProcedure
                    ).SingleOrDefault();
            }
            catch (Exception ex)
            {
                data.ResultMessage = ex.Message;
            }
            return data;
        }
    }
}
