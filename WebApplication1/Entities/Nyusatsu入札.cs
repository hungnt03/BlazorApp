using System;
using System.Collections.Generic;

#nullable disable

namespace Blazor.Server.Entities
{
    public partial class Nyusatsu入札
    {
        public Nyusatsu入札()
        {
            Nyusatsu入札明細s = new HashSet<Nyusatsu入札明細>();
        }

        public int 入札ｋｅｙ { get; set; }
        public string 入札コード { get; set; }
        public string 行政件名 { get; set; }
        public string 入札件名 { get; set; }
        public string 入札件名フリガナ { get; set; }
        public string 担当者 { get; set; }
        public string 品目 { get; set; }
        public int? 人数 { get; set; }
        public DateTime? 入札時期 { get; set; }
        public bool? 前年実施の有無 { get; set; }
        public decimal? 入札金額 { get; set; }
        public string 落札機関 { get; set; }
        public decimal? 落札金額 { get; set; }
        public bool? 競争入札参加資格申請書 { get; set; }
        public DateTime? 登録日 { get; set; }
        public DateTime? 有効期限 { get; set; }
        public int? 前年入札ｋｅｙ { get; set; }
        public DateTime? データ更新日 { get; set; }
        public string データ更新者 { get; set; }

        public virtual ICollection<Nyusatsu入札明細> Nyusatsu入札明細s { get; set; }
    }
}
