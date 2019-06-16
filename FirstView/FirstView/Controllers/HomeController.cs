using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstView.Models;
using PublishingHouse.Services;
using System.ComponentModel.DataAnnotations;

namespace FirstView.Controllers
{
    public class HomeController : Controller
    {
        protected AuthorService authorService = new AuthorService();
        protected CustomerService customerService = new CustomerService();


        public IActionResult Index()
        {
            
            return View();
        }
        public IActionResult about()
        {
            return View();
        }

        public ActionResult LoginJudge(string name, string password, string temp)
        {
            if ((temp == "author") && (authorService.LoginJudge(name, password)))
            {
                if (HttpContext.Request.Cookies.TryGetValue("getCookie", out _) == false)
                {
                    HttpContext.Response.Cookies.Append("getCookie", name);
                }
                
                return Json(new
                {
                    code =0,
                    type="author",
                }) ;
            }

            if ((temp == "customer") && (customerService.LoginJudge(name, password)))
            {
                if (HttpContext.Request.Cookies.TryGetValue("getCookie", out _) == false)
                {
                    HttpContext.Response.Cookies.Append("getCookie", name);
                }
                return Json(new
                {
                    code = 0,
                    type = "customer",
                });
            }
                
            return Json(new
            {
                code = 1,
            });
        }

        public IActionResult RegisterJudge(string Registerid, string firstpassword, string phone, string type)
        {
            int temp = 2050;
            if ((type == "author") && (authorService.RegisterJudge(Registerid, firstpassword, phone)))
            {
                return Redirect(Url.Action("Index", temp));
            }

            if ((type == "customer") && (customerService.RegisterJudge(Registerid, firstpassword, phone)))
            {

                return Redirect(Url.Action("Index", temp));
            }
            return Redirect(Url.Action("Index"));
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
