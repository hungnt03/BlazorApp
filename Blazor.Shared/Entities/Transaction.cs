using System;
using System.Collections.Generic;

#nullable disable

namespace Blazor.Shared.Entities
{
    public partial class Transaction
    {
        public int Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public int Type { get; set; }
        public int? CustomerId { get; set; }
        public int? SuplierId { get; set; }
        public bool IsPayment { get; set; }
        public int? Amount { get; set; }
        public int? Payment { get; set; }
        public int? PayBack { get; set; }
        public string BillNumber { get; set; }
        public string Note { get; set; }
    }
}
