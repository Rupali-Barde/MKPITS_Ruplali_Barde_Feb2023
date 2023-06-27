using Microsoft.AspNetCore.Mvc;

namespace MVC1ex.Controllers
{
    public class StudentController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
