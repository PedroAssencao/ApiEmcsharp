using ApiTarefas.Models;
using ApiTarefas.Repos.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiTarefas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepo _usuariorepo;
        public UsuarioController(IUsuarioRepo usuariorepo)
        {
            _usuariorepo = usuariorepo;
        }
        [HttpGet]
        public async Task <ActionResult<List<Usuario>>> BuscarTodosUsuarios()
        {
            List<Usuario> usuarios =  await _usuariorepo.BuscarTodosUsuarios();
            return Ok(usuarios);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Usuario>> BuscarPorId(int id)
        {
            Usuario usuarios = await _usuariorepo.BuscarPorID(id);
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
            Usuario usuarios = await _usuariorepo.Atualizar(usuario, id);
            return Ok(usuarios);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Usuario>> Apagar(int id)
        {
       
            bool usuarios = await _usuariorepo.Apagar(id);
            return Ok(usuarios);
        }


    }
}
