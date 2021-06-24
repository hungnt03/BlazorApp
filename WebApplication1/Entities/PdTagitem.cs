using System;
using System.Collections.Generic;

#nullable disable

namespace Blazor.Server.Entities
{
    public partial class PdTagitem
    {
        public int タグid { get; set; }
        public int ドキュメントid { get; set; }
        public bool? 表示有無 { get; set; }
        public int 表示順 { get; set; }

        public virtual PdTag タグ { get; set; }
        public virtual PdDocument ドキュメント { get; set; }
    }
}
