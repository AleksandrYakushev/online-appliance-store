using OnlineApplianceStore.Data.DTO;
using System.Collections.Generic;

namespace OnlineApplianceStore.Data.Repositories
{
    public interface IProductRepository
    {
        DataWrapper<ProductDto> CreateProduct(ProductDto dto);
        DataWrapper<ProductDto> DeleteProductById(long id);
        DataWrapper<List<ProductDto>> SelectAllProducts();
        DataWrapper<ProductDto> SelectProductById(long customerId);
        DataWrapper<ProductDto> UpdateProduct(ProductDto dto);
    }
}