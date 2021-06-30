using System;
using System.Collections.Generic;

#nullable disable

namespace Blazor.Shared.Entities
{
    public partial class ProductHistory
    {
        public int Id { get; set; }
        public string Barcode { get; set; }
        public int Unit { get; set; }
        public string NameOld { get; set; }
        public string NameNew { get; set; }
        public int? PriceBuyOld { get; set; }
        public int? PriceBuyNew { get; set; }
        public int? InterestOld { get; set; }
        public int? InterestNew { get; set; }
        public int? PriceOld { get; set; }
        public int? PriceNew { get; set; }
        public int? QuantityOld { get; set; }
        public int? QuantityNew { get; set; }
        public int? CategoryIdOld { get; set; }
        public int? CategoryIdNew { get; set; }
        public int? SupplierIdOld { get; set; }
        public int? SupplierIdNew { get; set; }
        public bool? PinOld { get; set; }
        public bool? PinNew { get; set; }
        public bool? EnableOld { get; set; }
        public bool? EnableNew { get; set; }
        public DateTime? ExpirationDateOld { get; set; }
        public DateTime? ExpirationDateNew { get; set; }
        public string ImgOld { get; set; }
        public string ImgNew { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public int Status { get; set; }
    }
}
