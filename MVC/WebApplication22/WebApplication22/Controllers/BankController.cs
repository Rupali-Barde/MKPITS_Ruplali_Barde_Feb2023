using AspNetCore;
using Microsoft.AspNetCore.Mvc;
using WebApplication22.Models;

namespace WebApplication22.Controllers
{
    public class BankController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Index(Bank b) 
        {
            ViewBag.customername = b.customername;
            ViewBag.amount = b.amount;
            ViewBag.balance = null;
            ViewBag.result = null;
            ViewBag.mode = null;
            if (b.mode == "deposit")
            {
                ViewBag.result = b.balance + b.amount;
            }

            if (b.mode == "withdraw")
            {
                ViewBag.result = b.balance - b.amount;
            }

            return View();
        }
    }
}
