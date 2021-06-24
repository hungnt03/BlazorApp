using System;
using System.Collections.Generic;

#nullable disable

namespace Blazor.Server.Entities
{
    public partial class Nyusatsu入札明細
    {
        public int 入札ｋｅｙ { get; set; }
        public int 入札明細番号 { get; set; }
        public string 品目 { get; set; }
        public int? 数量 { get; set; }
        public int? 単価 { get; set; }
        public decimal? 金額 { get; set; }

        public virtual Nyusatsu入札 入札ｋｅｙNavigation { get; set; }
    }
}
