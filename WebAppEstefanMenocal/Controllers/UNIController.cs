using Microsoft.AspNetCore.Mvc;

namespace WebAppEstefanMenocal.Controllers
{
    public class UNIController : Controller
    {
        public IActionResult Index()
        {
            var s = 0;
            return View();
        }
    }
}
