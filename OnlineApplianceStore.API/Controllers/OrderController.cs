using Microsoft.AspNetCore.Mvc;
using OnlineApplianceStore.Business.Models.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineApplianceStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : Controller
    {
        [HttpGet("{id}")]
        public ActionResult<List<OrderOutputModel>> GetOrder()
        {
            return null;
        }

        [HttpPost]
        public ActionResult<List<OrderOutputModel>> AddOrder()
        {
            return null;
        }

        [HttpPut]
        public ActionResult<List<OrderOutputModel>> UpdateOrder()
        {
            return null;
        }

        [HttpDelete("{id}")]
        public ActionResult<List<OrderOutputModel>> DeleteOrder()
        {
            return null;
        }

        [HttpGet("Search")]
        public ActionResult<List<OrderOutputModel>> GetSearchResult()
        {
            return null;
        }
    }
}
