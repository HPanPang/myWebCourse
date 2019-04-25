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
        public IActionResult Index()
        {
            //return View();
            return Redirect(Url.Action("Login"));
        }
        public IActionResult Login(int type)
        {
            if (type == 1)
            {
                return View(type);
            }
            return View();
        }
        public IActionResult changePwd(int type)
        {
            if (type == 1)
            {
                return View(type);
            }
            return View();
        }
        
        public IActionResult Judge(int id, string pwd)
        {
            if (pwd == null)
            {
                return Redirect(Url.Action("Login") + $"?type={3}");
            }
            else if (serviceStu.Judge(id, pwd))
            {
                return Redirect(Url.Action("index", "Student") + $"?id={id}");
            }
            else if (ServiceDr.Judge(id, pwd))
            {
                return Redirect(Url.Action("index", "Teacher") + $"?id={id}");
            }

            return Redirect(Url.Action("Login") + $"?type={1}");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
