using System;
using System.Collections.Generic;

#nullable disable

namespace Blazor.Server.Entities
{
    public partial class PdDocument
    {
        public PdDocument()
        {
            PdJireiItems = new HashSet<PdJireiItem>();
            PdTagitems = new HashSet<PdTagitem>();
        }

        public int ドキュメントid { get; set; }
        public int? 種別 { get; set; }
        public bool? 表示有無 { get; set; }
        public int? 表示順 { get; set; }
        public string 分類 { get; set; }
        public string 名称 { get; set; }
        public string ファイル名 { get; set; }
        public DateTime? 改定日 { get; set; }
        public DateTime? 更新日時 { get; set; }
        public string 更新者 { get; set; }

        public virtual ICollection<PdJireiItem> PdJireiItems { get; set; }
        public virtual ICollection<PdTagitem> PdTagitems { get; set; }
    }
}
