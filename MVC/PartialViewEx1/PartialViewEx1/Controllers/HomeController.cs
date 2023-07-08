using PartialViewEx1.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartialViewEx1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Teacher teacher = new Teacher();
            Student student = new Student();
            ViewBag.Message = "Welcome To My Demo!";
            dynamic mymodel = new ExpandoObject();
            mymodel.Teacher = teacher.GetTeachers();
            mymodel.Student = student.GetStudents();
            return View(mymodel);
            
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}