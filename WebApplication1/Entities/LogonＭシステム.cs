using System;
using System.Collections.Generic;

#nullable disable

namespace Blazor.Server.Entities
{
    public partial class LogonＭシステム
    {
        public LogonＭシステム()
        {
            LogonＴシステム利用s = new HashSet<LogonＴシステム利用>();
        }

        public string システムid { get; set; }
        public string システム名称 { get; set; }
        public bool? 許可既定値 { get; set; }

        public virtual ICollection<LogonＴシステム利用> LogonＴシステム利用s { get; set; }
    }
}
