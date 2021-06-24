using System;
using System.Collections.Generic;

#nullable disable

namespace Blazor.Server.Entities
{
    public partial class Seikyu閲覧用2
    {
        public int Id { get; set; }
        public int? 売伝番号 { get; set; }
        public string 請求書番号 { get; set; }
        public int? 部門コード { get; set; }
        public int? 担当者コード { get; set; }
        public string 担当者名 { get; set; }
        public string 得意先主コード { get; set; }
        public string 得意先補助コード { get; set; }
        public string 事業場名 { get; set; }
        public double? 商品コード { get; set; }
        public string 項目 { get; set; }
        public double? 単価 { get; set; }
        public int? 件数 { get; set; }
        public double? 売上金額 { get; set; }
        public DateTime? 伝票日付 { get; set; }
        public DateTime? 請求日付 { get; set; }
        public string 摘要１ { get; set; }
        public int? 赤黒 { get; set; }
        public int? 課税区分 { get; set; }
        public int Insertno { get; set; }
    }
}
