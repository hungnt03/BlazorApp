using System;
using System.Collections.Generic;

#nullable disable

namespace Blazor.Server.Entities
{
    public partial class HpHotnews
    {
        public Guid Id { get; set; }
        public bool Visible { get; set; }
        public DateTime DateUp { get; set; }
        public DateTime DateDel { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public string TitleSubText { get; set; }
        public string Topic { get; set; }
        public string Name { get; set; }
        public DateTime DateNow { get; set; }
        public DateTime DateUpdate { get; set; }
    }
}
