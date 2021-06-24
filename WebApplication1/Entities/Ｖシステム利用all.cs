using System;
using System.Collections.Generic;

#nullable disable

namespace Blazor.Server.Entities
{
    public partial class Ｖシステム利用all
    {
        public string ログオン名 { get; set; }
        public string 漢字氏名 { get; set; }
        public string 部署 { get; set; }
        public bool 使用フラグ { get; set; }
        public string システムid { get; set; }
        public string システム名称 { get; set; }
        public bool 許可既定値 { get; set; }
    }
}
