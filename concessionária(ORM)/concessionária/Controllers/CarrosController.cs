using concessionária.Models;
using concessionária.Services;
using Microsoft.AspNetCore.Mvc;

namespace concessionária.Controllers
{
    public class CarrosController : Controller
    {
        private readonly CarrosServices _carrosServices;

        public CarrosController(CarrosServices carros)
        {
            _carrosServices = carros;
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.CarrosView = await _carrosServices.ListaCarros();
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Carros carro, IFormFile car_img)
        {
            await _carrosServices.AdicionarCarros(carro, car_img);
            return RedirectToAction("index", "Carros");
        }

        [HttpGet]
        [Route("/carros/deletar/{id}")]
        public async Task<IActionResult> DeletarCarro(int id)
        {
            await _carrosServices.ApagarCarro(id);
            return RedirectToAction("index", "Carros");
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            ViewBag.Infos = await _carrosServices.BuscarPorID(id);
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Update(int id, Carros carro)
        {
            await _carrosServices.AtualizarCarros(id, carro);
            return RedirectToAction("Index", "Carros");
        }
    }
}
