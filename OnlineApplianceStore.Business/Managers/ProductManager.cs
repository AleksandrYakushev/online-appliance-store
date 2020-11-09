using AutoMapper;
using OnlineApplianceStore.Business.Models.Input;
using OnlineApplianceStore.Business.Models.Output;
using OnlineApplianceStore.Data;
using OnlineApplianceStore.Data.DTO;
using OnlineApplianceStore.Data.Repositories;
using System.Collections.Generic;

namespace OnlineApplianceStore.Business.Managers
{
    public class ProductManager : IProductManager
    {
        private IProductRepository _productRepository;
        private IMapper _mapper;

        public ProductManager(IProductRepository repo, IMapper mapper)
        {
            _productRepository = repo;
            _mapper = mapper;
        }

        public DataWrapper<ProductOutputModel> Merge(ProductInputModel inputModel)
        {
            var productDto = _mapper.Map<ProductInputModel, ProductDto>(inputModel);
            var data = _productRepository.MergeProduct(productDto);
            var mappedData = _mapper.Map<ProductDto, ProductOutputModel>(data.Data);
            return new DataWrapper<ProductOutputModel>
            {
                Data = mappedData,
                ResultMessage = data.ResultMessage
            };
        }

        public DataWrapper<ProductOutputModel> GetProduct(long id)
        {
            var data = _productRepository.SelectProductById(id);
            var mappedData = _mapper.Map<ProductDto, ProductOutputModel>(data.Data);
            return new DataWrapper<ProductOutputModel>
            {
                Data = mappedData,
                ResultMessage = data.ResultMessage
            };
        }

        public DataWrapper<List<ProductOutputModel>> GetAllProducts()
        {
            var data = _productRepository.SelectAllProducts();
            var mappedData = _mapper.Map<List<ProductOutputModel>>(data.Data);
            return new DataWrapper<List<ProductOutputModel>>
            {
                Data = mappedData,
                ResultMessage = data.ResultMessage
            };
        }

        public DataWrapper<ProductOutputModel> DeleteProduct(long id)
        {
            var data = _productRepository.DeleteProductById(id);
            var mappedData = _mapper.Map<ProductDto, ProductOutputModel>(data.Data);
            return new DataWrapper<ProductOutputModel>
            {
                Data = mappedData,
                ResultMessage = data.ResultMessage
            };
        }

    }
}
