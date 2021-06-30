using System;
using System.Collections.Generic;

#nullable disable

namespace Blazor.Shared.Entities
{
    public partial class TransactionDetail
    {
        public string Barcode { get; set; }
        public int TracsactionId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public int SuplierId { get; set; }
        public int Quantity { get; set; }
        public bool IsPayment { get; set; }
        public decimal Amount { get; set; }
        public int? Unit { get; set; }
        public bool? IsDiscount { get; set; }
    }
}
