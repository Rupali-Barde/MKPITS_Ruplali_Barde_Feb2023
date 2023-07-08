using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UsingViewModel.Models;

namespace UsingViewModel.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult IndexViewModel()
        {
            Teacher teacher = new Teacher();
            Student student = new Student();
            ViewBag.Message = "Welcome To My Class";
            ViewModel mymodel = new ViewModel();
            mymodel.Teachers = teacher.GetTeachers() ;
            mymodel.Students = student.GetStudents();
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