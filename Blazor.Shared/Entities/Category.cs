using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Blazor.Shared.Entities
{
    public partial class Category
    {
        public int Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
