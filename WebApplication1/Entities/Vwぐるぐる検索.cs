using System;
using System.Collections.Generic;

#nullable disable

namespace Blazor.Server.Entities
{
    public partial class Vwぐるぐる検索
    {
        public string 事業場コード { get; set; }
        public string 事業場名 { get; set; }
        public string カナ事業場名 { get; set; }
        public string 郵便番号 { get; set; }
        public string 住所 { get; set; }
        public string 電話番号 { get; set; }
        public string 定健hmp { get; set; }
        public string ドックhmp { get; set; }
        public string 定健健診 { get; set; }
        public string ドック健診 { get; set; }
        public string ストレス健診 { get; set; }
        public string 親事業場コード { get; set; }
        public string 上位事業場コード { get; set; }
        public string 保険者番号 { get; set; }
        public string 保険者名 { get; set; }
        public string 検索用電話番号 { get; set; }
    }
}
