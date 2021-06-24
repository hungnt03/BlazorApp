using System;
using System.Collections.Generic;

#nullable disable

namespace Blazor.Server.Entities
{
    public partial class PdJirei
    {
        public PdJirei()
        {
            PdJireiItems = new HashSet<PdJireiItem>();
            PdJireiTags = new HashSet<PdJireiTag>();
        }

        public int 事例id { get; set; }
        public string 事例 { get; set; }
        public bool? 表示有無 { get; set; }
        public int? 表示順 { get; set; }
        public DateTime? 更新日時 { get; set; }
        public string 更新者 { get; set; }

        public virtual ICollection<PdJireiItem> PdJireiItems { get; set; }
        public virtual ICollection<PdJireiTag> PdJireiTags { get; set; }
    }
}
