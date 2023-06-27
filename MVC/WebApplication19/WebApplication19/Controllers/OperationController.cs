using Microsoft.AspNetCore.Mvc;
using WebApplication19.Models;

namespace WebApplication19.Controllers
{
    public class OperationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Operation o)
        { 
         ViewBag.number1 = o.num1;
         ViewBag.number2 = o.num2;
            if(o.add == true)
            {
                o.result1 = o.num1 + o.num2;
                ViewBag.result1=o.result1;
            }
            if(o.subtract == true)
            {
                o.result2=o.num1 - o.num2;
                ViewBag.result2=o.result2;

            }
            if(o.multiply == true)
            {
                o.result3=o.num1 * o.num2;
                ViewBag.result3=o.result3;
            }
            return View();
        }
    }
}
