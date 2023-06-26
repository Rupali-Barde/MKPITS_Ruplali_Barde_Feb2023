using Microsoft.AspNetCore.Mvc;
using WebApplication12.Models;

namespace WebApplication12.Controllers
{
    public class CalculateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Index(Calculate m) 
        {
            int n1 = m.num1;
            int n2 = m.num2;
            int res = n1 + n2;
            ViewBag.result = res;
            return View();
        }
    }
}
