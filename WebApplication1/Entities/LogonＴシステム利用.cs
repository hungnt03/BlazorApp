using System;
using System.Collections.Generic;

#nullable disable

namespace Blazor.Server.Entities
{
    public partial class LogonＴシステム利用
    {
        public string ログオン名 { get; set; }
        public string システムid { get; set; }
        public bool? 使用フラグ { get; set; }

        public virtual LogonＭシステム システム { get; set; }
        public virtual LogonＭスタッフ ログオン名Navigation { get; set; }
    }
}
