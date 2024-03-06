using ApiAlmoxarifao.Api.Models;
using ApiAlmoxarifao.Api.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiAlmoxarifao.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemRequisicaoController : ControllerBase
    {
        [HttpPost]
        [Route("/item")]
        public IActionResult GetAllItemns()
        {
            Requisicao a = new Requisicao();
            return Ok(a);
        }
    }
}
