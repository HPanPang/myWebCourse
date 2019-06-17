using FirstView.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublishingHouse.Infrastructure
{
    public class AuthorRepository
    {
        public void Add(string Registerid, string password, string phone)
        {
            using (pressmannersystemContext context = new pressmannersystemContext())
            {
                Author author = new Author();
                author.Id = Registerid;
                author.Name = "作家";
                author.Password = password;
                author.Phone = phone;
                author.IsContact = "0";
                context.Author.Add(author);
                context.SaveChanges();
            }
        }

        public void Delete(string id)
        {
            using (var context = new pressmannersystemContext())
            {
                var author = context.Author.FirstOrDefault(x => x.Id == id);
                context.Author.Remove(author);
                context.SaveChanges();
            }
        }
        public void Update(Author author)
        {
            using (var context = new pressmannersystemContext())
            {
                context.Author.Update(author);
                context.SaveChanges();
            }
        }
        public Author Query(string id)
        {
            Author author = null;
            using (var context = new pressmannersystemContext())
            {
                author = context.Author.FirstOrDefault(x => x.Id == id);
                context.SaveChanges();
            }
            return author;
        }
        public Book QueryBook(string id)
        {
            Book book = null;
            using (var context = new pressmannersystemContext())
            {
                book = context.Book.FirstOrDefault(x => x.Id == id);
                context.SaveChanges();
            }
            return book;
        }
        public List<Bookauthor> QueryBookDetil(string id)
        {
            List<Bookauthor> listBook = new List<Bookauthor>();
            using (var context = new pressmannersystemContext())
            {
                listBook = (from u in context.Bookauthor
                            where u.Aid == id
                             select u
                             ).ToList();
                context.SaveChanges();
            }
            return listBook;
        }
    }
}
