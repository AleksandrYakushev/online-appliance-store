using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using OnlineApplianceStore.Business.Managers;
using OnlineApplianceStore.Business.Models.Input;
using OnlineApplianceStore.Business.Models.Output;

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


        /// <summary>
        /// Creates Product
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /deposit
        ///     {
        ///        "leadId": 1,
        ///        "amount": 200,
        ///        "currencyCode": "RUB"
        ///     }
        ///
        /// </remarks>      
        /// <returns> Created transaction Id</returns>
        /// <response code="200">Returns created transaction Id</response>
        /// <response code="422">If parameters weren't validated</response>
        /// <response code="520">If problem occured</response>
        [HttpPost]
        public ActionResult<List<ProductOutputModel>> AddProduct(ProductInputModel inputModel)
        {
            var result = _productManager.CreateProduct(inputModel);
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

//            /// <summary>
//            /// Creates deposit transaction
//            /// </summary>
//            /// <remarks>
//            /// Sample request:
//            ///
//            ///     POST /deposit
//            ///     {
//            ///        "leadId": 1,
//            ///        "amount": 200,
//            ///        "currencyCode": "RUB"
//            ///     }
//            ///
//            /// </remarks>      
//            /// <returns> Created transaction Id</returns>
//            /// <response code="200">Returns created transaction Id</response>
//            /// <response code="422">If parameters weren't validated</response>
//            /// <response code="520">If problem occured</response>
//            [HttpPost("deposit")]
//            public ActionResult<long> Deposit([FromBody] TransactionInputModel transaction)
//            {
//                var validationResult = _validation.ValidateTransaction(transaction);
//                if (validationResult != string.Empty)
//                {
//                    return UnprocessableEntity(validationResult);
//                }
//                var result = _transactionManager.Deposit(transaction);
//                return MakeResponse<long, long>(result);
//            }

//            /// <summary>
//            /// Creates withdraw transaction
//            /// </summary>
//            /// <remarks>
//            /// Sample request:
//            ///
//            ///     POST /withdraw
//            ///     {
//            ///        "leadId": 1,
//            ///        "amount": 200,
//            ///        "currencyCode": "RUB"
//            ///     }
//            ///
//            /// </remarks>
//            /// <returns> Created transaction Id</returns>
//            /// <response code="200">Returns created transaction Id</response>
//            /// <response code="422">If parameters weren't validated</response>
//            /// <response code="520">If problem occured</response>
//            [HttpPost("withdraw")]
//            public ActionResult<long> Withdraw([FromBody] TransactionInputModel transaction)
//            {
//                var validationResult = _validation.ValidateTransaction(transaction);
//                if (validationResult != string.Empty)
//                {
//                    return UnprocessableEntity(validationResult);
//                }
//                var result = _transactionManager.Withdraw(transaction);
//                return MakeResponse<long, long>(result);
//            }

//            /// <summary>
//            /// Creates transfer transaction
//            /// </summary>
//            /// <remarks>
//            /// Sample request:
//            ///
//            ///     POST /transfer
//            ///     {
//            ///        "senderId": 1,
//            ///        "recipientId": 2,
//            ///        "amount": 200,
//            ///        "currencyCode": "RUB"
//            ///     }
//            ///
//            /// </remarks>
//            /// <returns> Created  transactions Id</returns>
//            /// <response code="200">Returns created transactions Id</response>
//            /// <response code="422">If parameters weren't validated</response>
//            /// <response code="520">If problem occured</response>
//            [HttpPost("transfer")]
//            public ActionResult<List<long>> Transfer([FromBody] TransferInputModel transaction)
//            {
//                if (transaction.SenderId == transaction.RecipientId)
//                {
//                    return UnprocessableEntity(ResponseMessage.SenderAndRecipientIdValue);
//                }
//                var validationResult = _validation.ValidateAmount(transaction.Amount);
//                if (validationResult != string.Empty)
//                {
//                    return UnprocessableEntity(validationResult);
//                }
//                validationResult = _validation.ValidateCurrencyCode(transaction.CurrencyCode);
//                if (validationResult != string.Empty)
//                {
//                    return UnprocessableEntity(validationResult);
//                }
//                var result = _transactionManager.Transfer(transaction);
//                return MakeResponse<List<long>, List<long>>(result);
//            }

//            /// <summary>
//            /// Get a transaction by "id"
//            /// </summary>
//            /// <param name="id"></param>
//            /// <returns> Get transaction output model</returns>
//            /// <response code="200">Returns transaction by "id"</response>
//            /// <response code="404">if transaction is not found</response>
//            /// <response code="422">If parameters weren't validated</response>
//            /// <response code="520">If problem occured</response>
//            [HttpGet("{id}")]
//            public ActionResult<TransactionOutputModel> GetTransaction(long id)
//            {
//                var validationResult = _validation.ValidateId(id);
//                if (validationResult != string.Empty)
//                {
//                    return UnprocessableEntity(validationResult);
//                }
//                var transaction = _transactionManager.GetTransaction(id);
//                return MakeResponse<TransactionOutputModel, TransactionOutputModel>(transaction);
//            }

//            /// <summary>
//            /// Get all transactions by "leadId"
//            /// </summary>
//            /// <param name="leadId"></param>
//            /// <returns> Get all transactions output model by "leadId"</returns>
//            /// <response code="200">Returns all transactions by leadId </response>
//            /// <response code="404">if transaction is not found</response>
//            /// <response code="422">If parameters weren't validated</response>
//            /// <response code="520">If problem occured</response>
//            [HttpGet("lead/{leadid}")]
//            public IActionResult GetTransactionsByLeadId(long leadId)
//            {
//                var validationResult = _validation.ValidateId(leadId);
//                if (validationResult != string.Empty)
//                {
//                    return UnprocessableEntity(validationResult);
//                }
//                var transaction = _transactionManager.GetAllTransactionsByLeadId(leadId);
//                if (transaction.IsOk)
//                {
//                    if (transaction.Data == null)
//                    {
//                        return NotFound(ResponseMessage.TransactionNotFound);
//                    }
//                    string json = JsonConvert.SerializeObject(transaction.Data);
//                    return Ok(json);
//                }
//                return Problem(transaction.ExceptionMessage, statusCode: 520);
//            }

//            [HttpGet("all")]
//            public ActionResult<List<TransactionOutputModel>> GetAllTransactions()
//            {
//                var transactions = _transactionManager.GetAllTransactions();
//                return MakeResponse<List<TransactionOutputModel>, List<TransactionOutputModel>>(transactions);
//            }

//            /// <summary>
//            /// Get the leadId balance in the specified currency
//            /// </summary>
//            /// <param name="leadId"></param>
//            /// <returns> Get balance by leadId</returns>
//            /// <response code="200">Returns balance by leadId</response>
//            /// <response code="422">If parameters weren't validated</response>
//            /// <response code="520">If problem occured</response>
//            [HttpGet("balance/lead/{leadId}/{resultCurrency}")]
//            public IActionResult GetBalance(long leadId, string resultCurrency)
//            {
//                var validationResult = _validation.ValidateCurrencyCode(resultCurrency);
//                if (validationResult != string.Empty)
//                {
//                    return UnprocessableEntity(validationResult);
//                }
//                validationResult = _validation.ValidateId(leadId);
//                if (validationResult != string.Empty)
//                {
//                    return UnprocessableEntity(validationResult);
//                }
//                var transaction = _balanceManager.GetBalanceAmount(leadId, resultCurrency);
//                if (transaction.IsOk)
//                {
//                    return Ok(transaction.Data);
//                }
//                return Problem(transaction.ExceptionMessage, statusCode: 520);
//            }

//            [HttpGet("Search")]
//            public ActionResult<List<TransactionOutputModel>> GetSearchResult(SearchInputModel inputModel)
//            {
//                var results = _transactionManager.FindTransaction(inputModel);
//                return MakeResponse<List<TransactionOutputModel>, List<TransactionOutputModel>>(results);
//            }

//            //private ActionResult<T> MakeResponse<T, K>(DataWrapper<T> operationResult)
//            //{
//            //    if (operationResult.IsOk)
//            //    {
//            //        if (operationResult.Data == null)
//            //        {
//            //            return NotFound(ResponseMessage.TransactionNotFound);
//            //        }
//            //        return Ok(operationResult.Data);
//            //    }
//            //    return Problem(operationResult.ExceptionMessage, statusCode: 520);
//            //}
//        }
//}
