using Microsoft.AspNetCore.Mvc;
using WebApplication15.Models;

namespace WebApplication15.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Index(Product p)
        {
            ViewBag.name = p.name;
            int pr = p.price;
            int qt = p.qty;
            int res = pr * qt;
            ViewBag.result = res;
            return View();
        }
    }
}
