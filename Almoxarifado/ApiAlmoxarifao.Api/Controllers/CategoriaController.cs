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
        public async Task<List<Categoria>> GetTodasCategorias() => await _repository.GetAll();

        [HttpPost]
        [Route("/Categorias/Create")]
        public async Task<IActionResult> CreateCategorias(Categoria Model) => Ok(await _repository.Adicionar(Model));

        [HttpDelete]
        [Route("/Categorias/Delete/{id}")]
        public IActionResult DeletarCategoria(int id) => Ok(_repository.Delete(id));
    }
}
