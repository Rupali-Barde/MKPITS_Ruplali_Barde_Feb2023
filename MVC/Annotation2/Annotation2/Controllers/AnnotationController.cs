using Annotation2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Annotation2.Controllers
{
    public class AnnotationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        

         [HttpPost]
        public ActionResult StudentDetails(StudentDetails sd)
            {
                if (ModelState.IsValid)
                {
                    ViewBag.name = sd.Name;
                    ViewBag.email = sd.Email;
                    ViewBag.age = sd.Age;

                    
                    return View("Index");
                }
                else
                {
                    ViewBag.name = "No Data";
                    ViewBag.email = "No Data";
                ViewBag.age = "No Data";
                    
                    return View("Index");
                }
            }
        }
    }

