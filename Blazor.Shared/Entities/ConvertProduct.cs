using System;
using System.Collections.Generic;

#nullable disable

namespace Blazor.Shared.Entities
{
    public partial class ConvertProduct
    {
        public string Barcode1 { get; set; }
        public int Quantity1 { get; set; }
        public string Barcode2 { get; set; }
        public int Quantity2 { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
    }
}
