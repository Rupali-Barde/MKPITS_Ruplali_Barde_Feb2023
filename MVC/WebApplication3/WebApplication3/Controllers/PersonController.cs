using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
