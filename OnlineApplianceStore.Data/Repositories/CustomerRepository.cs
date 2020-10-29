using Microsoft.Extensions.Options;
using OnlineApplianceStore.Core;
using OnlineApplianceStore.Data.DTO;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;
using System.Data;
using System.Linq;

namespace OnlineApplianceStore.Data.Repositories
{
    public class CustomerRepository : BaseRepository, ICustomerRepository
    {
        public CustomerRepository(IOptions<DBSettings> options)
        {
            DbConnection = new SqlConnection(options.Value.ConnectionString);
        }

        public DataWrapper<CustomerDto> SelectCustomerById(long id)
        {
            var data = new DataWrapper<CustomerDto>();
            try
            {
                data.Data = DbConnection.Query<CustomerDto, CityDto, RoleDto, CustomerDto>(
                StoredProcedure.SelectCustomerProcedure,
                (lead, city, role) =>
                {
                    lead.City = city;
                    lead.Role = role;
                    return lead;
                },
                new { id },
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

        public DataWrapper<CustomerDto> DeleteCustomerById(long id)
        {
            var data = new DataWrapper<CustomerDto>();
            try
            {
                data.Data = DbConnection.Query<CustomerDto, CityDto, RoleDto, CustomerDto>(
                    StoredProcedure.DeleteCustomerProcedure,
                    (customer, city, role) =>
                    {
                        customer.City = city;
                        customer.Role = role;
                        return customer;
                    },
                    new { id },
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

        public DataWrapper<List<CustomerDto>> SelectAllCustomers()
        {
            var data = new DataWrapper<List<CustomerDto>>();
            try
            {
                data.Data = DbConnection.Query<CustomerDto, CityDto, RoleDto, CustomerDto>(
                    StoredProcedure.SelectAllCustomersProcedure,
                    (customer, city, role) =>
                    {
                        customer.City = city;
                        customer.Role = role;
                        return customer;
                    }, splitOn: "Id",
                    commandType: CommandType.StoredProcedure
                    ).ToList();
            }
            catch (Exception ex)
            {
                data.ResultMessage = ex.Message;
            }

            return data;
        }

        public DataWrapper<CustomerDto> CreateCustomer(CustomerDto customerDto)
        {
            var data = new DataWrapper<CustomerDto>();
            try
            {
                data.Data = DbConnection.Query<CustomerDto, CityDto, RoleDto, CustomerDto>(
                    StoredProcedure.CreateCustomerProcedure,
                    (customer, city, role) =>
                    {
                        customer.City = city;
                        customer.Role = role;
                        return customer;
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
    }
}
