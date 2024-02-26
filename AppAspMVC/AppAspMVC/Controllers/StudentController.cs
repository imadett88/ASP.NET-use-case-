using Microsoft.AspNetCore.Mvc;

namespace AppAspMVC.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
