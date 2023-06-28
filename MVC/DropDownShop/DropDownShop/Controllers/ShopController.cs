using DropDownShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace DropDownShop.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Index(UserShop us)
        {
            string custname = us.Customername;
            ViewBag.Customername = custname;
            int ordno = us.Orderno;
            ViewBag.Orderno = ordno;
            var selectedvalue =us.GetProdName;
            ViewBag.Prodname = selectedvalue.ToString();

            int price = us.Price;
            ViewBag.Price = price;
            int qty = us.Quantity;
            ViewBag.Quantity = qty;
            
            int tp = qty * price;
            ViewBag.Totalprice = tp;
            return View();
        }
    }
}
