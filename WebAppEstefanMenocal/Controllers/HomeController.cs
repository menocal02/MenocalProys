using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebAppEstefanMenocal.Models;

namespace WebAppEstefanMenocal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var model = new List<Paciente>()
            {
                new Paciente() { Nombre = "Estefan Menocal", Direccion = "Managua", Telefono = "8888-8888", Edad = 30 },
                new Paciente() { Nombre = "Carlos Zamora", Direccion = "Boaco", Telefono = "8888-8888", Edad = 40 }
            };

            return View(model);
        }

        public IActionResult Prueba()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
