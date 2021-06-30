using System;
using System.Collections.Generic;

#nullable disable

namespace Blazor.Shared.Entities
{
    public partial class Discount
    {
        public int Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public string Barcode { get; set; }
        public int Type { get; set; }
        public int CategoryId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
