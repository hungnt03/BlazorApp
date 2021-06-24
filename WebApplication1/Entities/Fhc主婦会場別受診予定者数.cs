using System;
using System.Collections.Generic;

#nullable disable

namespace Blazor.Server.Entities
{
    public partial class Fhc主婦会場別受診予定者数
    {
        public int 会場ｺｰﾄﾞ { get; set; }
        public string 会場名 { get; set; }
        public short? 会場no { get; set; }
        public DateTime? 健診日 { get; set; }
        public int? 受診予定者数 { get; set; }
        public short? 基本 { get; set; }
        public short? 眼底 { get; set; }
        public short? 胃直 { get; set; }
        public short? 胃間 { get; set; }
        public short? 乳ｴｺｰ { get; set; }
        public short? 乳ﾏﾝﾓ1 { get; set; }
        public short? 乳ﾏﾝﾓ2 { get; set; }
        public short? 子宮医 { get; set; }
        public short? 子宮自 { get; set; }
        public short? 骨 { get; set; }
        public short? 腹部 { get; set; }
        public short? 腹部3 { get; set; }
        public short? 腹部4 { get; set; }
        public short? 腹部5 { get; set; }
        public short? 腹囲 { get; set; }
        public short? ｵｰｼﾞｵ { get; set; }
        public string 備考 { get; set; }
        public short? 心電図 { get; set; }
        public short? 視力 { get; set; }
        public short? 体脂肪 { get; set; }
        public short? 便潜血 { get; set; }
        public short? 胸直 { get; set; }
        public short? 胸間 { get; set; }
        public short? 特定 { get; set; }
        public short? 乳ﾏﾝﾓ1pm { get; set; }
        public short? 乳ﾏﾝﾓ2pm { get; set; }
        public short? 定員数 { get; set; }
        public bool? Stop { get; set; }
    }
}
