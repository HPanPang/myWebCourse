using FirstView.Entities;
using PublishingHouse.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublishingHouse.Services
{
    public class CustomerService
    {
        private CustomerRepository customerRepository;
        public CustomerService()
        {
            customerRepository = new CustomerRepository();
        }
        public bool LoginJudge(string id, string password)
        {
            var customer = customerRepository.Query(id);
            if (customer == null)
                return false;
            if (customer.Password == password)
            {
                return true;
            }
            else
                return false;
        }

        public bool RegisterJudge(string Registerid, string password, string phone)
        {
            var customer = customerRepository.Query(Registerid);
            if (customer != null)
                return false;
            if (customer == null)
            {
                customerRepository.Add(Registerid, password, phone);
                return true;
            }
            return false;
        }
        public Customers Query(string id)
        {
            var customer = customerRepository.Query(id);
            return customer;
        }
        public void Update(Customers customer)
        {
            customerRepository.Update(customer);
        }
        public void ModifyPassword(string id, string newpasswordone)
        {
            customerRepository.ModifyPassword(id, newpasswordone);
        }
        public List<Book>QueryAll()
        {
            var bookList = customerRepository.QueryAll();
            return bookList;
        }

    }
}
