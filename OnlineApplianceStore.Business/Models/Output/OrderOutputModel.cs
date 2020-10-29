using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineApplianceStore.Business.Models.Output
{
    public class OrderOutputModel
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public int ProductAmount { get; set; }
        public long CustomerId { get; set; }
        public string OperationDate { get; set; }
        public int PaymentTypeId { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
