using Ejercicio01.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Ejercicio01.Controllers
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
            DateTime date = DateTime.Now;
            ViewData["Saludo"] = date.Hour > 6 && date.Hour < 12 ? "Buenos días" : date.Hour > 12 && date.Hour < 20 ? "Buenas tardes" : "Buenas noches";
            ViewBag.Saludo = date.ToLongDateString();

            clsPersona persona = new clsPersona();
            persona.nombre = "Amaro";
            persona.idPersona = 1;
            persona.telefono = "618646802";
            persona.fechaNac = new DateTime(2004,8,12);
            persona.direccion = "Mi casa";

            return View(persona);
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
