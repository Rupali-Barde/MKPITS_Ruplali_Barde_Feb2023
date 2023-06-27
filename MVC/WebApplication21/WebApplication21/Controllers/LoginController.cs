using Microsoft.AspNetCore.Mvc;
using WebApplication21.Models;

namespace WebApplication21.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Login i)
        {
            ViewBag.username = i.username;
            ViewBag.password = i.password;
            ViewBag.email = i.email;
            ViewBag.gender = i.gender;
            ViewBag.subject1 = null;
            ViewBag.subject2 = null;

            if(i.subject1 == true)
            {
                ViewBag.subject1 = "Dotnet";
            }
            if(i.subject2 == true)
            {
                ViewBag.subject2 = "Java";
            }
            return View();
          
        }
            
        
    }
}
