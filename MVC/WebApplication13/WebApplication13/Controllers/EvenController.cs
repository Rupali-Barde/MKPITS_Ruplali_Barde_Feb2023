using Microsoft.AspNetCore.Mvc;
using WebApplication13.Models;

namespace WebApplication13.Controllers
{
    public class EvenController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Even n)
        {
            int num = n.num;
            string result;
            if (num%2==0) 
            {
                result = "Even";
            }
            else
            {
                result = "Odd";
            }
            ViewBag.Result = result;
            return View();
        }
        
    }
}
