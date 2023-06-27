using Microsoft.AspNetCore.Mvc;
using WebApplication18.Models;

namespace WebApplication18.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(User u)
        {
            ViewBag.Tea = u.Tea.ToString();
            ViewBag.Loundry=u.Loundry.ToString();
            ViewBag.Breakfast=u.Breakfast.ToString();
            return View(u);

        }
    }
}
