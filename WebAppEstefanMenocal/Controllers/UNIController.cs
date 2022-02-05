using Microsoft.AspNetCore.Mvc;

namespace WebAppEstefanMenocal.Controllers
{
    public class UNIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
