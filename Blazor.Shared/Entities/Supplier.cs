using System;
using System.Collections.Generic;

#nullable disable

namespace Blazor.Shared.Entities
{
    public partial class Supplier
    {
        public int Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Contact1 { get; set; }
        public string Contact2 { get; set; }
        public string Note { get; set; }
    }
}
