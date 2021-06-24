using System;
using System.Collections.Generic;

#nullable disable

namespace Blazor.Server.Entities
{
    public partial class Souken
    {
        public short No { get; set; }
        public short 年 { get; set; }
        public string Path { get; set; }
        public string 登録担当 { get; set; }
        public DateTime? 登録日 { get; set; }
    }
}
