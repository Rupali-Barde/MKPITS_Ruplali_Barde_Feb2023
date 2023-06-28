using DropDown1.Models;
using Microsoft.AspNetCore.Mvc;

namespace DropDown1.Controllers
{
    public class DropdownController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(UserModel um)
        {
            var SelectedValue = um.SelectTeaType;
            ViewBag.TeaType = SelectedValue.ToString();
            
            return View();
        }
    }
}
