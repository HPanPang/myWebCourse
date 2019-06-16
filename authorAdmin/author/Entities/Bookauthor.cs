using System;
using System.Collections.Generic;

namespace author.Entities
{
    public partial class Bookauthor
    {
        public string Id { get; set; }
        public string Bid { get; set; }
        public string Aid { get; set; }

        public virtual Author A { get; set; }
        public virtual Book B { get; set; }
    }
}
