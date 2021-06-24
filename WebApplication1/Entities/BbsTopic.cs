using System;
using System.Collections.Generic;

#nullable disable

namespace Blazor.Server.Entities
{
    public partial class BbsTopic
    {
        public string BoardId { get; set; }
        public short Id { get; set; }
        public string Name { get; set; }
        public DateTime DateUp { get; set; }
        public DateTime DateDel { get; set; }
        public string Title { get; set; }
        public string Topic { get; set; }
        public bool Important { get; set; }
        public bool Up { get; set; }
        public bool Mail { get; set; }
        public string User { get; set; }
        public DateTime DateNow { get; set; }

        public virtual BbsBoard Board { get; set; }
    }
}
