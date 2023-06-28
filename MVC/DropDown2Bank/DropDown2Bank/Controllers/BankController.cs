using DropDown2Bank.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Principal;

namespace DropDown2Bank.Controllers
{
    public class BankController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(UserModel b)//class name
        {
            int bal = 1000;
            int actno = b.Accountno;
            int amount = b.Amount;
            var tt = b.GetTranstype;
            string tt1= tt.ToString();
            switch (tt1) 
            {
                case "deposit":
                    bal = bal + amount;
                    break;
                case "withdrawl":
                    bal =bal - amount;
                    break;
            }
            ViewBag.accountno = actno;
            ViewBag.balance = bal;
            return View();
        }
    }
}
