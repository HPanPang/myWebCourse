using FirstView.Entities;
using PublishingHouse.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublishingHouse.Services
{
    public class BookList
    {
        public String AuthorName;
        public int Num;
        public String Name;
        public String Statu;
        public DateTime PublishDate;
        public decimal Price;
        public int CountSale;
        public decimal Fee;
    }
    public class AuthorService
    {
        private AuthorRepository authorRepository;
        public AuthorService()
        {
            authorRepository = new AuthorRepository();
        }
        public bool LoginJudge(string id, string password)
        {
            var author = authorRepository.Query(id);
            if (author == null)
                return false;
            if (author.Password == password)
            {
                return true;
            }
            else
                return false;
        }
        public bool RegisterJudge(string Registerid, string password, string phone)
        {
            var author = authorRepository.Query(Registerid);
            if (author != null)
                return false;
            if (author == null)
            {
                authorRepository.Add(Registerid, password, phone);
                return true;
            }
            return false;
        }
        public Author Query(string id)
        {
            var author = authorRepository.Query(id);
            return author;
        }
        public bool Update(Author author)
        {
            authorRepository.Update(author);
            return true;
        }
        public List<BookList> GetBookLists(string id)
        {
            int count = 1;
            List<BookList> bookLists = new List<BookList>();
            var author = authorRepository.Query(id);
            var list = authorRepository.QueryBookDetil(id);

            for(int i = 0; i < list.Count; i++)
            {
                BookList temp = new BookList();
                temp.AuthorName = author.Name;
                temp.Num = count++;
                var book = authorRepository.QueryBook(list[i].Bid);
                temp.Name = book.Name;
                temp.PublishDate = book.PublicationDate;
                temp.Price = book.Price;
                temp.CountSale = int.Parse(book.Countsale);
                temp.Fee = book.Fee;
                if (temp.CountSale >= 5000 && book.Inventory >= 200)
                {
                    temp.Statu = "等待续签合同";
                }
                if (temp.CountSale < 5000 && book.Inventory >= 200)
                {
                    temp.Statu = "热销中";
                }
                if (book.Inventory < 200)
                {
                    temp.Statu = "备货中";
                }
                bookLists.Add(temp);
            }
            BookList temp2 = new BookList();
            temp2.AuthorName = author.Name;
            bookLists.Add(temp2);
            return bookLists;
        }
    }
}
