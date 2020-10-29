using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineApplianceStore.Business.Models.Input
{
    public class OrderInputModel
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public long CustomerId { get; set; }
        public long PaymentType { get; set; }
        public int ProductAmount { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
