using Microsoft.AspNetCore.Mvc;

namespace signup.Controllers
{
    public class SignupController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]


        public ActionResult Index(signup u)
        {
            ViewBag.username = u.username;
            ViewBag.password = u.password;
            return View();
        }

    }
}


