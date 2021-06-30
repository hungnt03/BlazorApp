using System;
using System.Collections.Generic;

#nullable disable

namespace Blazor.Shared.Entities
{
    public partial class VRevenue
    {
        public string CreateAt { get; set; }
        public int? Amount { get; set; }
        public decimal? DetailTotal { get; set; }
        public int? Interest { get; set; }
    }
}
