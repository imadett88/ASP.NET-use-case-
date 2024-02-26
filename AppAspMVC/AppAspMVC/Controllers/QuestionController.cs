using Microsoft.AspNetCore.Mvc;

namespace AppAspMVC.Controllers
{
    public class QuestionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
