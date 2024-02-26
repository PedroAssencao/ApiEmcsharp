using ApiAlmoxarifao.Api.Models;
using ApiAlmoxarifao.Api.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiAlmoxarifao.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentoController : ControllerBase
    {
        protected readonly DepartamentoRepository _departamentoRepository;

        public DepartamentoController(DepartamentoRepository departamentoRepository)
        {
            _departamentoRepository = departamentoRepository;
        }

        [HttpGet]
        [Route("/Departamento")]
        public List<Departamento> GetTodosDepartamentos() => _departamentoRepository.GetAll();

        [HttpPost]
        [Route("/Create/Departamento")]
        public async Task<IActionResult> CreateDepartamento(Departamento Model) => Ok(await _departamentoRepository.Adicionar(Model));
    }
}
