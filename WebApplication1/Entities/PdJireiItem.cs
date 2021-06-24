using System;
using System.Collections.Generic;

#nullable disable

namespace Blazor.Server.Entities
{
    public partial class PdJireiItem
    {
        public int 事例id { get; set; }
        public int ドキュメントid { get; set; }
        public bool? 表示有無 { get; set; }
        public int 表示順 { get; set; }

        public virtual PdDocument ドキュメント { get; set; }
        public virtual PdJirei 事例 { get; set; }
    }
}
