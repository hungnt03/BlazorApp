using System;
using System.Collections.Generic;

#nullable disable

namespace Blazor.Server.Entities
{
    public partial class BbsBoard
    {
        public BbsBoard()
        {
            BbsTopics = new HashSet<BbsTopic>();
        }

        public string BoardId { get; set; }
        public string BoardName { get; set; }

        public virtual ICollection<BbsTopic> BbsTopics { get; set; }
    }
}
