using System;
using System.Collections.Generic;

#nullable disable

namespace Blazor.Server.Entities
{
    public partial class Hp施設予約カレンダー
    {
        public int 機器コード { get; set; }
        public DateTime 日付 { get; set; }
        public int? 枠数 { get; set; }
        public int? 予約数 { get; set; }
        public int? 日付種別 { get; set; }
        public DateTime? 更新日時 { get; set; }
    }
}
