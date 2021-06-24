using System;
using System.Collections.Generic;

#nullable disable

namespace Blazor.Server.Entities
{
    public partial class Pcgrd使用状況
    {
        public string 通番 { get; set; }
        public string 購入年月日 { get; set; }
        public string Ｏｓ { get; set; }
        public string Macアドレス { get; set; }
        public string 設置場所 { get; set; }
        public string 設置場所詳細 { get; set; }
        public string 管理者１ { get; set; }
        public string 管理者２ { get; set; }
        public string 接続プリンタ { get; set; }
        public string Apsプリンタ { get; set; }
        public string クラス { get; set; }
        public string プリンタグループ { get; set; }
        public string 用途 { get; set; }
        public string 備考 { get; set; }
        public string ホスト接続形態 { get; set; }
    }
}
