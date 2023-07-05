using Microsoft.AspNetCore.Mvc;
using MVCConnection1.Models;

namespace MVCConnection1.Controllers
{
    public class ItemController : Controller
    {
        //Get Item
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        
        //post Method
        [HttpPost]
        public IActionResult Create (ItemModel ilist)
        {
            if(ModelState.IsValid)
            {
                ItemDBHandler db = new ItemDBHandler();
                if(db.InsertItem(ilist)) 
                {
                    ViewBag.message = "Item Saved Successfully";
                    ModelState.Clear();
                }
            }
            return View();
        }
        
        
    }
}
