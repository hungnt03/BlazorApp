using System;
using System.Collections.Generic;

#nullable disable

namespace Blazor.Server.Entities
{
    public partial class MenuSystem
    {
        public int Nodeno { get; set; }
        public int ParentNodeno { get; set; }
        public string システムid { get; set; }
        public int? 表示順 { get; set; }
        public string 表示名称 { get; set; }
        public string Url { get; set; }
        public string UrlTarget { get; set; }
        public string UrlImage { get; set; }
    }
}
