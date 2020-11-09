using Microsoft.AspNetCore.Mvc;
using OnlineApplianceStore.Business.Managers;
using OnlineApplianceStore.Business.Models.Input;
using OnlineApplianceStore.Business.Models.Output;
using System.Collections.Generic;

namespace OnlineApplianceStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private IOrderManager _orderManager;

        public OrderController(IOrderManager orderManager)
        {
            _orderManager = orderManager;
        }

        [HttpPost]
        public ActionResult<OrderOutputModel> AddOrder(OrderInputModel inputModel)
        {
            var result = _orderManager.Merge(inputModel);
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
        public ActionResult<OrderOutputModel> UpdateOrder(OrderInputModel inputModel)
        {
            var result = _orderManager.Merge(inputModel);
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
        public ActionResult<OrderOutputModel> GetOrder(long id)
        {
            var result = _orderManager.GetOrderById(id);
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
        public ActionResult<List<OrderOutputModel>> GetAllOrders()
        {
            var result = _orderManager.GetAllOrders();
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

        [HttpDelete("{id}")]
        public ActionResult<List<OrderOutputModel>> DeleteOrder(long id)
        {
            var result = _orderManager.DeleteOrderById(id);
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
        public ActionResult<List<OrderOutputModel>> GetSearchResult()
        {
            return null;
        }
    }
}
