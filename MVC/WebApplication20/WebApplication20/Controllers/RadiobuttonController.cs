using Microsoft.AspNetCore.Mvc;
using WebApplication20.Models;

namespace WebApplication20.Controllers
{
    public class RadiobuttonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Radiobutton b) 
        {
            ViewBag.number1 = b.num1;
            ViewBag.number2 = b.num2;
            string u = b.caltype;
            int result = 0;
            if(u=="add")
            {
                result = b.num1 + b.num2;
            }
            else if(u=="sub")
            {
             result = b.num1 - b.num2;
            }
            else if (u=="mul")
            {
                result = b.num1 * b.num2;
            }
            ViewBag.res = result;
            return View();
            
        }
    }    
}
