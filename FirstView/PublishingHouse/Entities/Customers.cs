using System;
using System.Collections.Generic;

namespace FirstView.Entities
{
    public partial class Customers
    {
        public Customers()
        {
            Order = new HashSet<Order>();
        }

        public string Cid { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Order> Order { get; set; }
    }
}
