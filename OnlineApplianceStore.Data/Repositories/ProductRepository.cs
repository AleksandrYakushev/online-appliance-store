using Dapper;
using Microsoft.Extensions.Options;
using OnlineApplianceStore.Core;
using OnlineApplianceStore.Data.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace OnlineApplianceStore.Data.Repositories
{
    public class ProductRepository : BaseRepository, IProductRepository
    {
        public ProductRepository(IOptions<DBSettings> options)
        {
            DbConnection = new SqlConnection(options.Value.ConnectionString);
        }

        public DataWrapper<ProductDto> MergeProduct(ProductDto dto)
        {
            var data = new DataWrapper<ProductDto>();
            try
            {
                data.Data = DbConnection.Query<ProductDto>(
                    StoredProcedure.MergeProductProcedure,
                    new
                    {
                        dto.Id,
                        dto.Name,
                        dto.Price,
                        dto.Length,
                        dto.Width,
                        dto.Height,
                        dto.Weight,
                        dto.Manufacturer,
                        dto.ProductionYear,
                        dto.MaxPower,
                        dto.NumberOfPrograms,
                        dto.Color,
                        dto.BowlVolume,
                        dto.ProductShape,
                        dto.ProductLife,
                        dto.NoiseLevel,
                        dto.MinTemperature,
                        dto.NumberOfToasts,
                        dto.BatteryLife,
                        dto.PowerRegulator,
                        dto.Timer,
                        dto.Defrost,
                        dto.SuperFrost,
                        dto.Backlight,
                        dto.Display,
                        dto.CarboneFilter,
                        dto.WetCleaning,
                        dto.GlassCase,
                        dto.RemoteController,
                        dto.WithBattery
                    },
                    commandType: CommandType.StoredProcedure
                    ).SingleOrDefault();
            }
            catch (Exception ex)
            {
                data.ResultMessage = ex.Message;
            }
            return data;
        }

        public DataWrapper<ProductDto> UpdateProduct(ProductDto dto)
        {
            var data = new DataWrapper<ProductDto>();
            try
            {
                data.Data = DbConnection.Query<ProductDto>(
                    StoredProcedure.UpdateCustomerProcedure,
                    new
                    {
                        dto.Name,
                        dto.Price,
                        dto.Length,
                        dto.Width,
                        dto.Height,
                        dto.Weight,
                        dto.Manufacturer,
                        dto.ProductionYear,
                        dto.MaxPower,
                        dto.NumberOfPrograms,
                        dto.Color,
                        dto.BowlVolume,
                        dto.ProductShape,
                        dto.ProductLife,
                        dto.NoiseLevel,
                        dto.MinTemperature,
                        dto.NumberOfToasts,
                        dto.BatteryLife,
                        dto.PowerRegulator,
                        dto.Timer,
                        dto.Defrost,
                        dto.SuperFrost,
                        dto.Backlight,
                        dto.Display,
                        dto.CarboneFilter,
                        dto.WetCleaning,
                        dto.GlassCase,
                        dto.RemoteController,
                        dto.WithBattery
                    },
                    commandType: CommandType.StoredProcedure
                    ).SingleOrDefault();
            }
            catch (Exception ex)
            {
                data.ResultMessage = ex.Message;
            }
            return data;
        }

        public DataWrapper<ProductDto> SelectProductById(long productId)
        {
            var data = new DataWrapper<ProductDto>();
            try
            {
                data.Data = DbConnection.Query<ProductDto>(
                StoredProcedure.CreateProductProcedure,
                new
                { productId },
                commandType: CommandType.StoredProcedure
                ).SingleOrDefault();
            }
            catch (Exception ex)
            {
                data.ResultMessage = ex.Message;
            }
            return data;
        }

        public DataWrapper<List<ProductDto>> SelectAllProducts()
        {
            var data = new DataWrapper<List<ProductDto>>();
            try
            {
                data.Data = DbConnection.Query<ProductDto>(
                    StoredProcedure.SelectAllProductsProcedure,
                    commandType: CommandType.StoredProcedure
                    ).ToList();
            }
            catch (Exception ex)
            {
                data.ResultMessage = ex.Message;
            }

            return data;
        }

        public DataWrapper<ProductDto> DeleteProductById(long productId)
        {
            var data = new DataWrapper<ProductDto>();
            try
            {
                data.Data = DbConnection.Query<ProductDto>(
                    StoredProcedure.DeleteProductProcedure,
                    new { productId },
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
