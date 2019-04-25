using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseDomain.Service;
using Microsoft.AspNetCore.Mvc;

namespace web_coursecontrol.Controllers
{
    public class TeacherController : Controller
    {

        protected TeacherService service { get; set; }

        public TeacherController()
        {
            service = new TeacherService();
        }
        public IActionResult Index(int id)
        {
            var teacher = service.GetDrInfo(id);

            return View(teacher);
        }
        public IActionResult Detial(int id)
        {
            var teacher = service.GetDrInfo(id);
            return Redirect(Url.Action("Index", "Home"));
        }
    }
}