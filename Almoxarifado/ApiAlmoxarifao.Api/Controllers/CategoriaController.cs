using ApiAlmoxarifao.Api.Models;
using ApiAlmoxarifao.Api.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiAlmoxarifao.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        protected readonly CategoriaRepository _repository;

        public CategoriaController(CategoriaRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("/Categorias")]
        public List<Categoria> GetTodasCategorias() => _repository.GetAll();

        [HttpPost]
        [Route("/Categorias/Create")]
        public async Task<IActionResult> CreateCategorias(Categoria Model) => Ok(await _repository.Adicionar(Model));
    }
}
