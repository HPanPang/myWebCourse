using System;
using System.Collections.Generic;

namespace author.Entities
{
    public partial class Order
    {
        public Order()
        {
            Orderdetail = new HashSet<Orderdetail>();
        }

        public string Id { get; set; }
        public string Cid { get; set; }
        public string OrderStatus { get; set; }
        public DateTime OrderTime { get; set; }
        public DateTime PayTime { get; set; }
        public decimal TotalPrice { get; set; }

        public virtual Customers C { get; set; }
        public virtual ICollection<Orderdetail> Orderdetail { get; set; }
    }
}
