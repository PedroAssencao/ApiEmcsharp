using concessionária.Models;
using concessionária.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace concessionária.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CarrosServices _carrosServices;

        public HomeController(ILogger<HomeController> logger, CarrosServices carros)
        {
            _logger = logger;
            _carrosServices = carros;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.CarrosView = await _carrosServices.ListaCarros();
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