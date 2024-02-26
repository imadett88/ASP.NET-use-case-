using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;


namespace AppAspMVC.Controllers
{
    public class EmpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Form1()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Form2()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Form2(int n1,int n2)
        {
            //processing
            int sum = n1 + n2;
            //ViewBag.n1 = n1;
            //ViewBag.n2 = n2;
            //ViewBag.sum = sum;
            ViewData["n1"] = n1.ToString();
            ViewData["n2"] = n2.ToString();
            ViewData["sum"] = sum.ToString();
            return View();
        }

        [HttpGet]
        public IActionResult Form3()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Form3(string tname,string gendre, int age,string status, string note)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Form4()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Form4(int n1, int n2)
        {
            int sum = n1 + n2;
            TempData["n1"] = n1.ToString();
            TempData["n2"]= n2.ToString();
            TempData["sum"]=sum.ToString();
            return RedirectToAction("Form5");
        }

        [HttpGet]
        public IActionResult Form5()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Form5")]
        public IActionResult back()
        {
            return RedirectToAction("Form4");
        }

        [HttpGet]
        public IActionResult Form6()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Form6(int n1, int n2)
        {
            int sum = n1 + n2;
            HttpContext.Session.SetString("sum", sum.ToString());


            return RedirectToAction("Form7");
        }

        [HttpGet]
        public IActionResult Form7()
        {
            ViewBag.totald = HttpContext.Session.GetString("sum");
            return View();
        }

        [HttpPost]
        [ActionName("From7")]
        public IActionResult BackToForm6()
        {
            return View();
        }




    }
}
