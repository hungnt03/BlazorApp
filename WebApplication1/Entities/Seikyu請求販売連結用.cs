using System;
using System.Collections.Generic;

#nullable disable

namespace Blazor.Server.Entities
{
    public partial class Seikyu請求販売連結用
    {
        public int Id { get; set; }
        public int? 通し番号 { get; set; }
        public int? 販売登録番号 { get; set; }
        public DateTime? 販売登録日 { get; set; }
        public string 備考 { get; set; }
        public string 送付関係 { get; set; }
        public string 遅延理由 { get; set; }
        public int Insertno { get; set; }
    }
}
