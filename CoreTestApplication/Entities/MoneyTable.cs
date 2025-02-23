using System;
using System.Collections.Generic;

#nullable disable

namespace CoreTestApplication.Entities
{
    public partial class MoneyTable
    {
        public int MoneyId { get; set; }
        public double BidPrice { get; set; }
        public decimal SellingPrice { get; set; }
        public DateTime? CreatedBy { get; set; }
    }
}
