using System;
using System.Collections.Generic;

#nullable disable

namespace Blazor.Server.Entities
{
    public partial class H設備予約t
    {
        public string Id { get; set; }
        public string 予約品id { get; set; }
        public string 職員コード { get; set; }
        public DateTime? 開始日時 { get; set; }
        public DateTime? 終了日時 { get; set; }
        public string 種別cd { get; set; }
        public string 詳細 { get; set; }
        public string キャンセルフラグ { get; set; }
        public DateTime? 更新日時 { get; set; }
    }
}
