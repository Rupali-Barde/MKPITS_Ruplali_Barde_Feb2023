using Microsoft.AspNetCore.Mvc;
using Microsoft.JSInterop.Infrastructure;
using SignUp_Form.Models;

namespace SignUp_Form.Controllers
{
    public class SignUpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Index(UserModel1 um)
        {
            ViewBag.Username = um.UserName;
            ViewBag.Gender = um.Gender;
            
          
            return View();
        }
    }
}
