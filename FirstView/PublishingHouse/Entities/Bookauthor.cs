using System;
using System.Collections.Generic;

namespace FirstView.Entities
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
