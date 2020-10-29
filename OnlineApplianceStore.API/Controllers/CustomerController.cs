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
    public class CustomerController : Controller
    {
        ICustomerRepository _repository;
        CustomerManager _manager;

        [HttpGet("{id}")]
        public ActionResult<CustomerOutputModel> GetCustomer(long id)
        {
            var result = _manager.GetCustomer(id);
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
            var result = _manager.GetAllCustomers();
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

        [HttpPost]
        public ActionResult<List<CustomerOutputModel>> AddCustomer()
        {
            return null;
        }

        [HttpPut]
        public ActionResult<List<CustomerOutputModel>> UpdateCustomer()
        {
            return null;
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
