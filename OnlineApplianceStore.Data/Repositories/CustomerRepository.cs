using Microsoft.Extensions.Options;
using OnlineApplianceStore.Core;
using OnlineApplianceStore.Data.DTO;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        public DataWrapper<CustomerDto> CreateCustomer(CustomerDto dto)
        {
            var data = new DataWrapper<CustomerDto>();
            try
            {
                data.Data = DbConnection.Query<CustomerDto, RoleDto, CityDto, CustomerDto>(
                    StoredProcedure.CreateCustomerProcedure,
                    (customer, role, city) =>
                    {
                        customer.Role = role;
                        customer.City = city;
                        return customer;
                    },
                    new
                    {
                        CityId = dto.City.Id,
                        dto.Name,
                        dto.LastName,
                        dto.Birthday,
                        dto.Address,
                        dto.Phone,
                        dto.Email,
                        dto.Password
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

        public DataWrapper<CustomerDto> MergeCustomer(CustomerDto dto)
        {
            var data = new DataWrapper<CustomerDto>();
            try
            {
                data.Data = DbConnection.Query<CustomerDto, RoleDto, CityDto, CustomerDto>(
                    StoredProcedure.UpdateCustomerProcedure,
                    (customer, role, city) =>
                    {
                        customer.Role = role;
                        customer.City = city;
                        return customer;
                    },
                    new
                    {
                        dto.Id,
                        CityId = dto.City.Id,
                        RoleId = dto.Role.Id,
                        dto.Name,
                        dto.LastName,
                        dto.Birthday,
                        dto.Address,
                        dto.Phone,
                        dto.Email,
                        dto.Password
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

        public DataWrapper<CustomerDto> SelectCustomerById(long customerId)
        {
            var data = new DataWrapper<CustomerDto>();
            try
            {
                data.Data = DbConnection.Query<CustomerDto, RoleDto, CityDto, CustomerDto>(
                StoredProcedure.SelectCustomerProcedure,
                (customer, role, city) =>
                {
                    customer.Role = role;
                    customer.City = city;
                    return customer;
                },
                new { customerId },
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
                data.Data = DbConnection.Query<CustomerDto, RoleDto, CityDto, CustomerDto>(
                    StoredProcedure.SelectAllCustomersProcedure,
                    (customer, role, city) =>
                    {
                        customer.Role = role;
                        customer.City = city;
                        return customer;
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

        public DataWrapper<CustomerDto> DeleteCustomerById(long id)
        {
            var data = new DataWrapper<CustomerDto>();
            try
            {
                data.Data = DbConnection.Query<CustomerDto, RoleDto, CityDto,  CustomerDto>(
                    StoredProcedure.DeleteCustomerProcedure,
                    (customer, role, city) =>
                    {
                        customer.Role = role;
                        customer.City = city;
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
    }
}
