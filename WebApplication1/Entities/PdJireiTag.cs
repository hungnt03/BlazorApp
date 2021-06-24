using System;
using System.Collections.Generic;

#nullable disable

namespace Blazor.Server.Entities
{
    public partial class PdJireiTag
    {
        public int 事例id { get; set; }
        public int タグid { get; set; }
        public bool? 表示有無 { get; set; }
        public int 表示順 { get; set; }

        public virtual PdTag タグ { get; set; }
        public virtual PdJirei 事例 { get; set; }
    }
}
