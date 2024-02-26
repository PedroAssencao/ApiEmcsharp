using ApiAlmoxarifao.Api.Models;
using ApiAlmoxarifao.Api.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiAlmoxarifao.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        protected readonly ProdutoRepositroy _repo;

        public ProdutoController(ProdutoRepositroy repo)
        {
            _repo = repo;
        }

        [HttpGet]
        [Route("/produto")]
        public async Task<List<Produto>> GetTodosProdutos() => await _repo.GetProdutos();

        [HttpPost]
        [Route("/produto/Create")]
        public async Task<IActionResult> CriarNovoProdutos([FromForm] ProdutoView Model) => Ok(await _repo.AdicionarImagem(Model));


    }
}
