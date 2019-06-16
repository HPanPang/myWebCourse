using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using com.sun.corba.se.spi.activation;
using Microsoft.AspNetCore.Mvc;
using web_coursecontrol.Models;

namespace web_coursecontrol.Controllers
{
    public class AuthorController : Controller
    {
        public object StrScript { get; private set; }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ShowInfo()
        {
            return View();
        }
        public IActionResult UpdateInfo()
        {
            return View();
        }
        public IActionResult Upload()
        {
            return View();
        }
        public IActionResult fee()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        
        //public IActionResult UpdateNow(string xinming, int xuehao, string xueyuan, string mingzu, string sex, string chushengdi, string lianxidianhua, string shengfenzheng)
        //{
        //    var student = service.GetStuInfo(xuehao);
        //    if (xinming != null) { student.StuName = xinming; }
        //    if (xueyuan != null) { student.Xueyuan = xueyuan; }
        //    if (mingzu != null) { student.Mingzu = mingzu; }
        //    if (sex != null) { student.Sex = sex; }
        //    if (chushengdi != null) { student.Chushengdi = chushengdi; }
        //    if (lianxidianhua != null) { student.Shoujihaoma = lianxidianhua; }
        //    if (shengfenzheng != null) { student.Shengfenzheng = shengfenzheng; }
        //    student.UpdateTime = DateTime.Now;
        //    service.Update(student);
        //    return View("UpdateInfo", student);
        //}
        public IActionResult changePwd()
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
