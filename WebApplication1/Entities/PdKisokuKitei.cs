using System;
using System.Collections.Generic;

#nullable disable

namespace Blazor.Server.Entities
{
    public partial class PdKisokuKitei
    {
        public int 規則規定id { get; set; }
        public bool? 表示有無 { get; set; }
        public int? 表示順 { get; set; }
        public string 大分類 { get; set; }
        public string 中分類 { get; set; }
        public string 名称 { get; set; }
        public int? タグid { get; set; }
        public DateTime? 更新日時 { get; set; }
        public string 更新者 { get; set; }

        public virtual PdTag タグ { get; set; }
    }
}
