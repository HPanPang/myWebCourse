using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstView.Models;
using PublishingHouse.Services;
using FirstView.Entities;

namespace FirstView.Controllers
{
    public class CustomerController : Controller
    {
        protected CustomerService customerService = new CustomerService();
        public IActionResult Index()
        {
            var getCookie = "";
            HttpContext.Request.Cookies.TryGetValue("getCookie", out getCookie);
            var customer = customerService.Query(getCookie);
            return View(customer);
        }
        public IActionResult Information()
        {
            var getCookie = "";
            HttpContext.Request.Cookies.TryGetValue("getCookie", out getCookie);
            if(getCookie==null)
            {
                return Redirect(Url.Action("Index", "Home"));
            }
            var customer = customerService.Query(getCookie);
            return View(customer);
        }
        public IActionResult ModifyJudge(string name, string sex, int age, string number, string email, string address)
        {
            var getCookie = "";
            HttpContext.Request.Cookies.TryGetValue("getCookie", out getCookie);
            if (getCookie == null)
            {
                return Redirect(Url.Action("Index", "Home"));
            }
            var customer = customerService.Query(getCookie);
            customer.Name = name;
            customer.Sex = sex;
            customer.Age = age;
            customer.Phone = number;
            customer.Mail = email;
            customer.Address = address;
            customerService.Update(customer);
            return Redirect(Url.Action("Information"));
        }
        public IActionResult BookInformation()
        {
            var bookList = customerService.QueryAll();
            return View(bookList);
        }
        public IActionResult ModifyPassword()
        {
            var getCookie = "";
            HttpContext.Request.Cookies.TryGetValue("getCookie", out getCookie);
            if (getCookie == null)
            {
                return Redirect(Url.Action("Index", "Home"));
            }
            var customer = customerService.Query(getCookie);
            return View(customer);
        }


        public IActionResult ModifyPd( string newpasswordone)
        {
            var getCookie = "";
            HttpContext.Request.Cookies.TryGetValue("getCookie", out getCookie);
            if (getCookie == null)
            {
                return Redirect(Url.Action("Index", "Home"));
            }
            var customer = customerService.Query(getCookie);
            if(customer.Password!=newpasswordone)
            {
                customerService.ModifyPassword(getCookie, newpasswordone);
            }
            return Redirect(Url.Action("ModifyPassword"));
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
