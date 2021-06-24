using System;
using System.Collections.Generic;

#nullable disable

namespace Blazor.Server.Entities
{
    public partial class Hスケジュールt
    {
        public string Id { get; set; }
        public string 職員コード { get; set; }
        public DateTime? 開始日時 { get; set; }
        public DateTime? 終了日時 { get; set; }
        public string 内容 { get; set; }
        public string 詳細 { get; set; }
        public string 種別cd { get; set; }
        public string 直行f { get; set; }
        public string 直帰f { get; set; }
        public string 削除フラグ { get; set; }
    }
}
