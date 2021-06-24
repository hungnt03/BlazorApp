using System;
using System.Collections.Generic;

#nullable disable

namespace Blazor.Server.Entities
{
    public partial class PdTag
    {
        public PdTag()
        {
            PdJireiTags = new HashSet<PdJireiTag>();
            PdKisokuKiteis = new HashSet<PdKisokuKitei>();
            PdTagitems = new HashSet<PdTagitem>();
        }

        public int タグid { get; set; }
        public bool? 表示有無 { get; set; }
        public int? 表示順 { get; set; }
        public string タグ { get; set; }
        public DateTime? 更新日時 { get; set; }
        public string 更新者 { get; set; }

        public virtual ICollection<PdJireiTag> PdJireiTags { get; set; }
        public virtual ICollection<PdKisokuKitei> PdKisokuKiteis { get; set; }
        public virtual ICollection<PdTagitem> PdTagitems { get; set; }
    }
}
