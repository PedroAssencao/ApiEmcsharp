using Microsoft.AspNetCore.Mvc;

namespace concessionária.Controllers
{
    public class MotosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
