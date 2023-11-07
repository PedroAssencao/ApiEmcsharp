using ApiTarefas.Models;
using ApiTarefas.Repos;
using ApiTarefas.Repos.Interfaces;
using ApiTarefas.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiTarefas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuarioService _usuarioService;
        private readonly IUsuarioRepo _usuariorepo;

        public UsuarioController(IUsuarioRepo usuarioRepo, UsuarioService usuarioService)
        {
            _usuariorepo = usuarioRepo;
            _usuarioService = usuarioService;
        }

        [HttpGet]
        [Route("BuscarUsuarios")]
        public async Task <ActionResult<List<Usuario>>> BuscarTodosUsuarios()
        {
            List<Usuario> usuarios =  await _usuariorepo.BuscarTodosUsuarios();
            return Ok(usuarios);
        }

        [HttpGet]
        [Route("BuscarUsuarios/{id}")]
        public async Task<ActionResult<Usuario>> BuscarPorId(int id)
        {
            Usuario? usuarios = await _usuariorepo.BuscarPorID(id);
            return Ok(usuarios);
        }

        [HttpPost]
        public async Task<ActionResult<Usuario>> Cadastrar([FromBody] Usuario usuario)
        {
            Usuario usuarios = await _usuariorepo.Adicionar(usuario);
            return Ok(usuarios);
        }


        [HttpPut("{id}")]   
        public async Task<ActionResult<Usuario>> Atualizar([FromBody] Usuario usuario,int id)
        {
            usuario.id = id;
            Usuario usuarios = await _usuarioService.Atualizar(usuario, id);
            return Ok(usuarios);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Usuario>> Apagar(int id)
        {
       
            bool usuarios = await _usuarioService.Apagar(id);
            return Ok(usuarios);
        }


    }
}
