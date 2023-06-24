using Microsoft.AspNetCore.Mvc;

namespace WebApplication6.Controllers
{
    public class ConditionalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
