using System;
using System.Collections.Generic;

#nullable disable

namespace Blazor.Server.Entities
{
    public partial class SftName
    {
        public string メーカーｉｄ { get; set; }
        public string コード { get; set; }
        public string ソフト名称 { get; set; }
        public string 備考1 { get; set; }
        public string 使用者ログオン { get; set; }
        public string 使用者パソコン { get; set; }
        public string ファイル名 { get; set; }
        public DateTime? 更新日 { get; set; }
        public byte[] 更新スタンプ { get; set; }
    }
}
