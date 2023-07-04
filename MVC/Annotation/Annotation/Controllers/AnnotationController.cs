using Annotation.Models;
using Microsoft.AspNetCore.Mvc;

namespace Annotation.Controllers
{
    public class AnnotationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult StudentDetails(StudentModel sm)
        {
            if(ModelState.IsValid)
            {
                ViewBag.name = sm.Name;
                ViewBag.email = sm.Email;
                ViewBag.age = sm.Age;
                return View("Index");
            }
            else
            {
                ViewBag.name = "No Data";
                ViewBag.email = "No Data";
                ViewBag.age = "No Date";
                return View("Index");
            }
        }
    }
}
