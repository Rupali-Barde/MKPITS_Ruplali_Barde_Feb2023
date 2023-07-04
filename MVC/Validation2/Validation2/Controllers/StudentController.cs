using Microsoft.AspNetCore.Mvc;
using Validation2.Models;

namespace Validation2.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult StudentModel(StudentModel sm)
        {
            if(string.IsNullOrEmpty(sm.Name))
            {
                ModelState.AddModelError("Name", "Name Required ");
            }
            if(sm.Age == 0 || sm.Age > 120)
            {
                ModelState.AddModelError("Age", "Please Enter Valid Age Beetween 1-120  ");

            }

            if (ModelState.IsValid)
            {
                ViewBag.name = sm.Name;
                ViewBag.age = sm.Age;
                return View("Index");

            }
            else
            {
                ViewBag.name = "No Data";
                ViewBag.age = "No Data";
                return View("Index");
            }
        }

    }
}
