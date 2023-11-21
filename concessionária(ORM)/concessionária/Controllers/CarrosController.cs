using Microsoft.AspNetCore.Mvc;

namespace concessionária.Controllers
{
    public class CarrosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
