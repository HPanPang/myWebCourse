using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using web_coursecontrol.Models;

namespace web_coursecontrol.Controllers
{
    public class HomeController : Controller
    {
        public object StrScript { get; private set; }

        public IActionResult Index()
        {
            return Redirect(Url.Action("Index", "Author"));
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
