using System;
using System.Collections.Generic;

#nullable disable

namespace Blazor.Server.Entities
{
    public partial class JigJc販売
    {
        public string 事業場コード { get; set; }
        public string 健診実施事業場名 { get; set; }
        public string 得意先主コード { get; set; }
        public string 得意先補助コード { get; set; }
        public string 請求先事業場名 { get; set; }
        public bool 事業場明細 { get; set; }
        public bool 個人結果 { get; set; }
        public bool 成人病一覧 { get; set; }
        public bool 指定用紙 { get; set; }
        public bool 受診券 { get; set; }
        public bool Ｆｄ { get; set; }
        public bool 会長印 { get; set; }
        public string その他 { get; set; }
        public string 得意先ｺｰﾄﾞ { get; set; }
        public int? 得意先区分 { get; set; }
        public int? 請求区分 { get; set; }
        public string 連想 { get; set; }
        public string 正式名称 { get; set; }
        public string 簡略名称 { get; set; }
        public string 郵便番号１ { get; set; }
        public string 住所上段 { get; set; }
        public string 住所下段 { get; set; }
        public string 受注担当者名 { get; set; }
    }
}
