using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using OnlineApplianceStore.Business.Managers;
using OnlineApplianceStore.Business.Models.Input;
using OnlineApplianceStore.Business.Models.Output;
using OnlineApplianceStore.Data;

namespace OnlineApplianceStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductManager _productManager;

        public ProductController(IProductManager productManager)
        {
            _productManager = productManager;
        }

        [HttpPost]
        public ActionResult<ProductOutputModel> AddProduct(ProductInputModel inputModel)
        {
            var result = _productManager.Merge(inputModel);
            if (result.IsOK)
            {
                if (result.Data == null)
                {
                    return NotFound();
                }
                return Ok(result.Data);
            }
            return Problem(detail: result.ResultMessage, statusCode: 520);
        }

        [HttpPut]
        public ActionResult<ProductOutputModel> UpdateProduct(ProductInputModel inputModel)
        {
            var result = _productManager.Merge(inputModel);
            if (result.IsOK)
            {
                if (result.Data == null)
                {
                    return NotFound();
                }
                return Ok(result.Data);
            }
            return Problem(detail: result.ResultMessage, statusCode: 520);
        }


        [HttpGet("{id}")]
        public ActionResult<ProductOutputModel> GetProduct(long id)
        {
            var result = _productManager.GetProduct(id);
            if (result.IsOK)
            {
                if (result.Data == null)
                {
                    return NotFound();
                }
                return Ok(result.Data);
            }
            return Problem(detail: result.ResultMessage, statusCode: 520);
        }

        [HttpGet("all")]
        public ActionResult<List<ProductOutputModel>> GetAllProducts()
        {
            var result = _productManager.GetAllProducts();
            if (result.IsOK)
            {
                if (result.Data == null)
                {
                    return NotFound();
                }
                return Ok(result.Data);
            }
            return Problem(detail: result.ResultMessage, statusCode: 520);
        }

        [HttpGet("Search")]
        public ActionResult<List<ProductOutputModel>> GetSearchResult()
        {
            return null;
        }
    }
}
