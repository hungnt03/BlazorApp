using System;
using System.Collections.Generic;

#nullable disable

namespace Blazor.Server.Entities
{
    public partial class LogonＭスタッフ
    {
        public LogonＭスタッフ()
        {
            LogonＴシステム利用s = new HashSet<LogonＴシステム利用>();
        }

        public string ログオン名 { get; set; }
        public string 職員コード { get; set; }
        public string 漢字氏名 { get; set; }
        public string カナ氏名 { get; set; }
        public string 部署 { get; set; }
        public string 部 { get; set; }
        public string 課 { get; set; }
        public string メール { get; set; }
        public string パソコン { get; set; }
        public bool? 対象外 { get; set; }
        public DateTime? 更新日時 { get; set; }

        public virtual ICollection<LogonＴシステム利用> LogonＴシステム利用s { get; set; }
    }
}
