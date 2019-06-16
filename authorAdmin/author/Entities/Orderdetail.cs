using System;
using System.Collections.Generic;

namespace author.Entities
{
    public partial class Orderdetail
    {
        public string Id { get; set; }
        public string Pid { get; set; }
        public string Oid { get; set; }
        public string Quantity { get; set; }
        public decimal Subtotal { get; set; }

        public virtual Order O { get; set; }
        public virtual Book P { get; set; }
    }
}
