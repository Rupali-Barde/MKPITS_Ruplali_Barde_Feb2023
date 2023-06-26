using Microsoft.AspNetCore.Mvc;
using WebApplication11.Models;

namespace WebApplication11.Controllers
{
    public class SignupController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Index(Signup u)
        {
            ViewBag.username = u.username;
            ViewBag.password = u.password;
            return View();
        }

    }
}
