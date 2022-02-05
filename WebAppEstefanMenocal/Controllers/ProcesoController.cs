using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebAppEstefanMenocal.Controllers
{
    public class ProcesoController : Controller
    {
        public IActionResult Index()
        {

            return View("Procesos");
        }
    }
}
