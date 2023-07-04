using Microsoft.AspNetCore.Mvc;
using Validation.Models;

namespace Validation.Controllers
{
    public class ValidationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(StudentModel sm) 
        {
            if(ModelState.IsValid)
            {
                return View(sm);
            }
            else
            {
                return View();
            }
        }
    }
}
