using FirstView.Entities;
using PublishingHouse.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublishingHouse.Services
{
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
    }
}
