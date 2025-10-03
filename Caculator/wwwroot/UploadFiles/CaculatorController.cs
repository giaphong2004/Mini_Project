using Microsoft.AspNetCore.Mvc;

namespace Caculator.Controllers
{
    public class CaculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Calculate(double a = 0, double b = 0, char o = '+') 
        {
            switch (o)
            {
                case '+':
                    ViewBag.ketQua = a + b;
                    break;
                case '-':
                    ViewBag.ketQua = a - b;
                    break;
                case '*':
                    ViewBag.ketQua = a * b;
                    break;
                case ':':
                    ViewBag.ketQua = a / b;
                    break;
            }
            return View("Calculate");
        }
    }
}
