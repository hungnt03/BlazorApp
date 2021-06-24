using System;
using System.Collections.Generic;

#nullable disable

namespace Blazor.Server.Entities
{
    public partial class 要望依頼
    {
        public long Id { get; set; }
        public int? 保存ステータス { get; set; }
        public int? ステータス { get; set; }
        public DateTime? 起票日 { get; set; }
        public string 起票者 { get; set; }
        public int? 起票部署 { get; set; }
        public DateTime? 希望納期 { get; set; }
        public bool? 特になし { get; set; }
        public int? システムまたは業務 { get; set; }
        public bool? 上記以外 { get; set; }
        public string 上記以外text { get; set; }
        public string 依頼内容 { get; set; }
        public string ファイル添付 { get; set; }
        public string 効果 { get; set; }
        public int? 費用効果 { get; set; }
        public string 緊急の理由 { get; set; }
        public int? 緊急依頼の承認者 { get; set; }
        public int? 受付担当 { get; set; }
        public DateTime? 受付日 { get; set; }
        public string 影響範囲 { get; set; }
        public string 工数単位 { get; set; }
        public double? 内部工数 { get; set; }
        public int? 金額 { get; set; }
        public int? 外注金額 { get; set; }
        public string 外注備考 { get; set; }
        public int? 購買金額 { get; set; }
        public string 購買備考 { get; set; }
        public int? その他金額 { get; set; }
        public string その他備考 { get; set; }
        public int? 見積集計 { get; set; }
        public int? 対応要否 { get; set; }
        public int? 理由 { get; set; }
        public string 補足 { get; set; }
        public int? 対応者1 { get; set; }
        public int? 対応者2 { get; set; }
        public DateTime? 納期 { get; set; }
        public bool? 依頼者の希望通り { get; set; }
        public int? 進捗 { get; set; }
        public string FileKey { get; set; }
        public string 備考 { get; set; }
        public DateTime? 完了日 { get; set; }
    }
}
