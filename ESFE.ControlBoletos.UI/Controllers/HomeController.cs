using ESFE.ControlBoletos.BL.Service;
using ESFE.ControlBoletos.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ESFE.ControlBoletos.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAsignacionService _asignacionService;

        public HomeController(IAsignacionService AsignacionServi)
        {
            _asignacionService = AsignacionServi;
        }

        public IActionResult Index()
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