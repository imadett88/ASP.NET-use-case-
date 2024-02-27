using Microsoft.AspNetCore.Mvc;

namespace AppAspMVC.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
