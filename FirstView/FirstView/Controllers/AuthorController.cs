using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstView.Models;
using PublishingHouse.Services;

namespace FirstView.Controllers
{
    public class AuthorController : Controller
    {
        public object StrScript { get; private set; }
        protected AuthorService authorService = new AuthorService();
        public IActionResult Index()
        {
            var getCookie = "";
            HttpContext.Request.Cookies.TryGetValue("getCookie", out getCookie);
            if (getCookie == null)
            {
                return Redirect(Url.Action("Index", "Home"));
            }
            var author = authorService.Query(getCookie);
            return View(author);
        }
        public IActionResult ShowInfo()
        {
            var getCookie = "";
            HttpContext.Request.Cookies.TryGetValue("getCookie", out getCookie);
            if (getCookie == null)
            {
                return Redirect(Url.Action("Index", "Home"));
            }
            var author = authorService.Query(getCookie);
            return View(author);
        }
        public IActionResult UpdateInfo()
        {
            var getCookie = "";
            HttpContext.Request.Cookies.TryGetValue("getCookie", out getCookie);
            if (getCookie == null)
            {
                return Redirect(Url.Action("Index", "Home"));
            }
            var author = authorService.Query(getCookie);
            return View(author);
        }
        public IActionResult Upload()
        {
            var getCookie = "";
            HttpContext.Request.Cookies.TryGetValue("getCookie", out getCookie);
            if (getCookie == null)
            {
                return Redirect(Url.Action("Index", "Home"));
            }
            var author = authorService.Query(getCookie);
            return View(author);
        }
        public IActionResult fee()
        {
            var getCookie = "";
            HttpContext.Request.Cookies.TryGetValue("getCookie", out getCookie);
            if (getCookie == null)
            {
                return Redirect(Url.Action("Index", "Home"));
            }
            var author = authorService.Query(getCookie);
            return View(author);
        }
        public IActionResult Contact()
        {
            var getCookie = "";
            HttpContext.Request.Cookies.TryGetValue("getCookie", out getCookie);
            if (getCookie == null)
            {
                return Redirect(Url.Action("Index", "Home"));
            }
            var author = authorService.Query(getCookie);
            return View(author);
        }
        public IActionResult logout()
        {
            string key = "";
            HttpContext.Request.Cookies.TryGetValue(key, out string value);
            HttpContext.Response.Cookies.Delete(key);
            return Redirect(Url.Action("Index", "Home"));
        }

        public IActionResult UpdateNow(string name, string phone, string address, string isContact)
        {
            var getCookie = "";
            int count = 0;
            HttpContext.Request.Cookies.TryGetValue("getCookie", out getCookie);

            if (getCookie == null)
            {
                return Redirect(Url.Action("Index", "Home"));
            }
            var author = authorService.Query(getCookie);
            if (name != null) { author.Name = name; count++; }
            if (phone != null) { author.Phone = phone; count++; }
            if (address != null) { author.Address = address; count++; }
            if (isContact != null)
            {
                if (isContact == "是")
                {
                    count++;
                    author.IsContact = "1";
                }
                    
                if (isContact == "否")
                {
                    count++;
                    author.IsContact = "0";
                }
                    
            }
            authorService.Update(author);
            return Json(new
            {
                code = count,
            });
        }
        public IActionResult changePwd()
        {
            var getCookie = "";
            HttpContext.Request.Cookies.TryGetValue("getCookie", out getCookie);
            if (getCookie == null)
            {
                return Redirect(Url.Action("Index", "Home"));
            }
            var author = authorService.Query(getCookie);
            return View(author);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
