using System;
using System.Collections.Generic;

#nullable disable

namespace Blazor.Server.Entities
{
    public partial class Hp施設予約
    {
        public int 予約連番 { get; set; }
        public int? 機器コード { get; set; }
        public DateTime? 日付 { get; set; }
        public string 事業所名 { get; set; }
        public string 所属名 { get; set; }
        public string 氏名 { get; set; }
        public string フリガナ { get; set; }
        public int? 性別 { get; set; }
        public string メールアドレス { get; set; }
        public string 連絡先電話番号 { get; set; }
        public string 備考 { get; set; }
        public DateTime? 更新日時 { get; set; }
    }
}
