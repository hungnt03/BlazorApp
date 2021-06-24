using System;
using System.Collections.Generic;

#nullable disable

namespace Blazor.Server.Entities
{
    public partial class ViewerError管理
    {
        public decimal イベントid { get; set; }
        public string ソース { get; set; }
        public string サーバ名 { get; set; }
        public DateTime 発生日時 { get; set; }
        public string 説明 { get; set; }
        public string 解説 { get; set; }
        public int ランク { get; set; }
        public int 種類 { get; set; }
        public string 分類 { get; set; }
        public string 発生源pc { get; set; }
        public string ユーザ { get; set; }
        public string ログ名 { get; set; }
        public string 登録者 { get; set; }
        public DateTime 登録日 { get; set; }
    }
}
