using BankDetails.Models;
using Microsoft.AspNetCore.Mvc;

namespace BankDetails.Controllers
{
    public class BankController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Bank bank)
        {
            ViewBag.customername = bank.customername;
            ViewBag.amount = bank.amount;
            ViewBag.balance = null;
            ViewBag.result = null;
            ViewBag.mode = null;
            if (bank.mode == "deposit")
            {
                ViewBag.result = bank.balance + bank.amount;
            }

            if (bank.mode == "withdraw")
            {
                ViewBag.result = bank.balance - bank.amount;
            }

            return View();
        }
    }
}

    

