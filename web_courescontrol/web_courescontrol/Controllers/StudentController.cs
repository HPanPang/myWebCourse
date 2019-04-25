using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseDomain.Service;
using Microsoft.AspNetCore.Mvc;

namespace web_coursecontrol.Controllers
{
    public class StudentController : Controller
    {
        protected StudentService service { get; set; }

        public StudentController()
        {
            service = new StudentService();
        }
        public IActionResult Index(int id)
        {
            var student = service.GetStuInfo(id);
            return View(student);
        }
        public IActionResult Select(int id)
        {
            var student = service.GetStuInfo(id);
            return View(student);
        }
        public IActionResult ShowInfo(int id)
        {
            var student = service.GetStuInfo(id);
            return View(student);
        }
        public IActionResult ShowCourseInfo(int id)
        {
            var scoreList = service.GetCourseList(id);
            return View(scoreList);
        }
        public IActionResult UpdateInfo(int id)
        {
            var student = service.GetStuInfo(id);
            return View(student);
        }
        public IActionResult ChooseTongshi(int id)
        {
            var TSlist = service.GetCourseList("通识核心课程",id);
            return View(TSlist);
        }
        public IActionResult Choosezhuanyefangxiang(int id)
        {
            var TSlist = service.GetCourseList("专业方向课程", id);
            return View(TSlist);
        }
        public IActionResult Choosezhuanyejichu(int id)
        {
            var TSlist = service.GetCourseList("专业基础课程", id);
            return View(TSlist);
        }
        public IActionResult SelectCourse(int id,int code ,int type)
        {
            if (type == 2580)
            {
                service.SelectCourse(id, code);
                return Redirect(Url.Action("Choosezhuanyefangxiang") + $"?id={id}");
            }
            if (type == 2581)
            {
                service.SelectCourse(id, code);
                return Redirect(Url.Action("Choosezhuanyejichu") + $"?id={id}");
            }
            service.SelectCourse(id, code);
            return Redirect(Url.Action("ChooseTongshi") + $"?id={id}");

        }
        public IActionResult TuiXuan(int id, int code, int type)
        {
            if (type == 2580)
            {
                service.TuiXuan(id, code);
                return Redirect(Url.Action("Choosezhuanyefangxiang") + $"?id={id}");
            }
            if (type == 2581)
            {
                service.TuiXuan(id, code);
                return Redirect(Url.Action("Choosezhuanyejichu") + $"?id={id}");
            }
            service.TuiXuan(id, code);
            return Redirect(Url.Action("ChooseTongshi") + $"?id={id}");
        }
        public IActionResult UpdateNow(string xinming,int xuehao,string xueyuan,string mingzu,string sex,string chushengdi,string lianxidianhua,string shengfenzheng)
        {
            var student = service.GetStuInfo(xuehao);
            if (xinming != null) { student.StuName = xinming; }
            if (xueyuan != null) { student.Xueyuan = xueyuan; }
            if (mingzu != null) { student.Mingzu = mingzu; }
            if (sex != null) { student.Sex = sex; }
            if (chushengdi != null) { student.Chushengdi = chushengdi; }
            if (lianxidianhua != null) { student.Shoujihaoma = lianxidianhua; }
            if (shengfenzheng != null) { student.Shengfenzheng = shengfenzheng; }
            student.UpdateTime = DateTime.Now;
            service.Update(student);
            return View("UpdateInfo",student);
        }
        public IActionResult changePwd(int id,int type)
        {
            var student = service.GetStuInfo(id);
            if (type == 1)
            {
                ViewBag.type = 1;
                return View(student);
            }
            else if(type == 2)
            {
                ViewBag.type = 2;
                return View(student);
            }
            return View(student);
        }
        public IActionResult JudgePwd(int id, string oldPwd, string newPwd)
        {
            if (service.JudgePwd(id, oldPwd, newPwd))
            {
                return Redirect(Url.Action("changePwd") + $"?id={id}" + $"&type={1}");
            }
            return Redirect(Url.Action("changePwd") + $"?id={id}" + $"&type={2}");
        }
    }
}