using System;
using System.Collections.Generic;

#nullable disable

namespace Blazor.Shared.Entities
{
    public partial class Product
    {
        public string Barcode { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int CategoryId { get; set; }
        public int SupplierId { get; set; }
        public bool? Pin { get; set; }
        public bool Enable { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public int Unit { get; set; }
        public string Img { get; set; }
        public int? PriceBuy { get; set; }
        public int? Interest { get; set; }
    }
}
