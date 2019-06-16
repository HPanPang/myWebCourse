using System;
using System.Collections.Generic;

namespace author.Entities
{
    public partial class Author
    {
        public Author()
        {
            Bookauthor = new HashSet<Bookauthor>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string IsContact { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Bookauthor> Bookauthor { get; set; }
    }
}
