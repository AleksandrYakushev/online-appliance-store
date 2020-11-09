using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineApplianceStore.Data.DTO
{
    public class OrderDto
    {
        public long Id { get; set; }
        public int ProductAmount { get; set; }
        public DateTime OperationDate { get; set; }
        public decimal TotalAmount { get; set; }
        public CustomerDto Customer { get; set; }
        public ProductDto Product { get; set; }
        public PaymentTypeDto PaymentType { get; set; }
    }
}
