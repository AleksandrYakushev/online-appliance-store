using Microsoft.AspNetCore.Mvc;
using OnlineApplianceStore.Business.Managers;
using OnlineApplianceStore.Business.Models.Input;
using OnlineApplianceStore.Business.Models.Output;
using System.Collections.Generic;

namespace OnlineApplianceStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ICustomerManager _customerManager;

        public CustomerController(ICustomerManager customerManager)
        {
            _customerManager = customerManager;
        }

        [HttpPost]
        public ActionResult<CustomerOutputModel> AddCustomer(CustomerInputModel inputModel)
        {
            var result = _customerManager.Merge(inputModel);
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
        public ActionResult<CustomerOutputModel> UpdateCustomer(CustomerInputModel inputModel)
        {
            var result = _customerManager.Merge(inputModel);
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
        public ActionResult<CustomerOutputModel> GetCustomer(long id)
        {
            var result = _customerManager.GetCustomer(id);
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
        public ActionResult<List<CustomerOutputModel>> GetAllCustomers()
        {
            var result = _customerManager.GetAllCustomers();
            if (result.IsOK)
            {
                if(result.Data == null)
                {
                    return NotFound();
                }
                return Ok(result.Data);
            }
            return Problem(detail: result.ResultMessage, statusCode: 520);
        }

        [HttpDelete("{id}")]
        public ActionResult<CustomerOutputModel> DeleteCustomer(long id)
        {
            var result = _customerManager.DeleteCustomer(id);
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
        public ActionResult<List<CustomerOutputModel>> GetSearchResult()
        {
            return null;
        }
    }
}
