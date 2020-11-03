using Microsoft.AspNetCore.Mvc;
using OnlineApplianceStore.Business.Managers;
using OnlineApplianceStore.Business.Models.Input;
using OnlineApplianceStore.Business.Models.Output;
using OnlineApplianceStore.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        //example of valid data
        //"name": "George",
        //"lastName": "Ford",
        //"birthday": "06.15.2008",
        //"address": "address",
        //"phone": "345678",
        //"email": "email@gmail.com",
        //"password": "password",
        //"cityid": 1
        [HttpPost]
        public ActionResult<List<CustomerOutputModel>> AddCustomer(CustomerInputModel inputModel)
        {
            var result = _customerManager.CreateCustomer(inputModel);
            if(result.IsOK)
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
        public ActionResult<List<CustomerOutputModel>> UpdateCustomer(CustomerInputModel inputModel)
        {
            var result = _customerManager.UpdateCustomer(inputModel);
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
            return null;
        }

        [HttpGet("Search")]
        public ActionResult<List<CustomerOutputModel>> GetSearchResult()
        {
            return null; 
        }
        
    }
}
