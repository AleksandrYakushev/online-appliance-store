﻿using OnlineApplianceStore.Data.DTO;
using System.Collections.Generic;

namespace OnlineApplianceStore.Data.Repositories
{
    public interface IProductRepository
    {
        DataWrapper<ProductDto> MergeProduct(ProductDto dto);
        DataWrapper<List<ProductDto>> SelectAllProducts();
        DataWrapper<ProductDto> SelectProductById(long customerId);
        DataWrapper<ProductDto> DeleteProductById(long id);
    }
}