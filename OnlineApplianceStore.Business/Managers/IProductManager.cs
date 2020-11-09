using OnlineApplianceStore.Business.Models.Input;
using OnlineApplianceStore.Business.Models.Output;
using OnlineApplianceStore.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineApplianceStore.Business.Managers
{
    public interface IProductManager
    {
        DataWrapper<ProductOutputModel> Merge(ProductInputModel inputModel);
        DataWrapper<ProductOutputModel> GetProduct(long id);
        DataWrapper<List<ProductOutputModel>> GetAllProducts();
        DataWrapper<ProductOutputModel> DeleteProduct(long id);
    }
}
