using DisplayFor.Models;
using Microsoft.AspNetCore.Mvc;

namespace DisplayFor.Controllers
{
    public class DisplayController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Index(IFormCollection fc, Display d)
        {
            if(ModelState.IsValid)
            {
                d.UserName = fc["UserName"];
                return View(d);
            }
            else 
            { 
                return View(); 
            }
        }
    }
}
