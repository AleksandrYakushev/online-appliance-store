using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineApplianceStore.Business.Models.Input
{
    public class SearchInputOrderModel
    {
        public long? Id { get; set; }
        public long? CustomerId { get; set; }
        public long? ProductId { get; set; }
        public int? ProductAmount { get; set; }
        public string PaymentType { get; set; }
        public string OrderStartDate { get; set; }
        public string OrderEndDate { get; set; }
    }
}
