using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CourseDomain.Service;
using Microsoft.AspNetCore.Mvc;
using web_coursecontrol.Models;

namespace web_coursecontrol.Controllers
{
    public class HomeController : Controller
    {
        protected StudentService serviceStu { get; set; }
        protected TeacherService ServiceDr { get; set; }
        public object StrScript { get; private set; }

        public HomeController()
        {
            serviceStu = new StudentService();
            ServiceDr = new TeacherService();
        }
        public IActionResult Index(int type)
        {
            if (type == 1)
            {
                ViewBag.type = 1;
                return View(type);
            }
            return View();
        }
        public IActionResult Judge(int id, string pwd)
        {
            if (serviceStu.Judge(id, pwd))
            {
                return Redirect(Url.Action("Index", "Student") + $"?id={id}");
            }
            else if (ServiceDr.Judge(id, pwd))
            {
                return Redirect(Url.Action("Index", "Teacher") + $"?id={id}");
            }
            return Redirect(Url.Action("Index") + $"?type={1}");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
