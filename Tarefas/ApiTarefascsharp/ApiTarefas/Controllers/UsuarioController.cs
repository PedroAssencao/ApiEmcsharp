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

        public UsuarioController(UsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet]
        [Route("BuscarUsuarios")]
        public async Task<IActionResult> BuscarTodosUsuarios()
        {
            List<Usuario> usuarios = await _usuarioService.ListaUsuario();
            return Ok(usuarios);
        }

        [HttpGet]
        [Route("BuscarUsuarios/{id}")]
        public async Task<ActionResult<Usuario>> BuscarPorId(int id)
        {
            Usuario? usuarios = await _usuarioService.BuscarUsuarioExpecifico(id);
            return Ok(usuarios);
        }

        [HttpPost]
        public async Task<ActionResult<Usuario>> Cadastrar([FromBody] Usuario usuario)
        {
            Usuario usuarios = await _usuarioService.AdicionarUsuario(usuario);
            return Ok(usuarios);
        }


        [HttpPut("{id}")]
        public async Task<ActionResult<Usuario>> Atualizar(int id, [FromBody] Usuario usuario)
        {
            Usuario usuarios = await _usuarioService.AtualizarUsuario(id, usuario);
            return usuarios;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Usuario>> Apagar(int id)
        {
            bool usuarios = await _usuarioService.ApagarUsuario(id);
            return Ok(usuarios);
        }


    }
}
