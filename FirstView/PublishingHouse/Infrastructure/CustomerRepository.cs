using FirstView.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublishingHouse.Infrastructure
{
    public class CustomerRepository
    {
        public void Add(string Registerid, string password, string phone)
        {
            using (pressmannersystemContext context = new pressmannersystemContext())
            {
                Customers customer = new Customers();
                customer.Cid = Registerid;
                customer.Name = "默认姓名";
                customer.Sex = "男";
                customer.Age = 18;
                customer.Address = "默认地址";
                customer.Password = password;
                customer.Phone = phone;
                context.Customers.Add(customer);
                context.SaveChanges();
            }
        }

        public void ModifyPassword(string id,string newpassword)
        {
            using (var context = new pressmannersystemContext())
            {
                var customer = Query(id);
                customer.Password = newpassword;
                context.Customers.Update(customer);
                context.SaveChanges();
            }
                
        }
        public void Delete(string id)
        {
            using (var context = new pressmannersystemContext())
            {
                var customer = context.Customers.FirstOrDefault(x => x.Cid == id);
                context.Customers.Remove(customer);
                context.SaveChanges();
            }
        }
        public void Update(Customers customer)
        {
            using (var context = new pressmannersystemContext())
            {
                context.Customers.Update(customer);
                context.SaveChanges();
            }
        }
        public Customers Query(string id)
        {
            Customers customer = null;
            using (var context = new pressmannersystemContext())
            {
                customer = context.Customers.FirstOrDefault(x => x.Cid == id);
                context.SaveChanges();
            }
            return customer;
        }
        public List<Book>QueryAll()
        {
            List<Book> BookList = new List<Book>();
            using (var context = new pressmannersystemContext())
            {
                BookList = (from u in context.Book
                            select u
                            ).ToList();
                context.SaveChanges();
            }
            return BookList;
        }
     

    }
}
