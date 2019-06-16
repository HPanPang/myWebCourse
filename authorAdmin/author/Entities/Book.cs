using System;
using System.Collections.Generic;

namespace author.Entities
{
    public partial class Book
    {
        public Book()
        {
            Bookauthor = new HashSet<Bookauthor>();
            Orderdetail = new HashSet<Orderdetail>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Isbn { get; set; }
        public decimal Inventory { get; set; }
        public DateTime PublicationDate { get; set; }
        public string WordCount { get; set; }
        public string PageCount { get; set; }
        public string Format { get; set; }
        public string Type { get; set; }
        public string Content { get; set; }
        public decimal Fee { get; set; }
        public string Editor { get; set; }
        public string Countsale { get; set; }

        public virtual ICollection<Bookauthor> Bookauthor { get; set; }
        public virtual ICollection<Orderdetail> Orderdetail { get; set; }
    }
}
