using Microsoft.AspNetCore.Mvc;
using PrimeiraApi.Models;
using System.Diagnostics.CodeAnalysis;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PrimeiraApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        // GET: api/<UsuarioController>
        [HttpGet]
        public IEnumerable<UsuarioModel_> Get()
        {
            List<UsuarioModel_> usuarioModels = new List<UsuarioModel_>();

            usuarioModels.Add(new UsuarioModel_() { id = 1, Nome = "Pedro", email = "pedro31102006@teste.123" });

            return usuarioModels;
        }

        // GET api/<UsuarioController>/5
        [HttpGet("{id}")]
        public UsuarioModel_ Get(int id)
        {
            UsuarioModel_ usuario = new UsuarioModel_() { id = 1, Nome = "Pedro", email = "pedro31102006@teste.123" };
            return usuario;
        }

        // POST api/<UsuarioController>
        [HttpPost]
        public void Post([FromBody] UsuarioModel_ usuario)
        {
        }

        // PUT api/<UsuarioController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] UsuarioModel_ usuario)
        {
        }

        // DELETE api/<UsuarioController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
