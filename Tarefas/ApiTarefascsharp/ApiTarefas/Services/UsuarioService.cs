using ApiTarefas.Data;
using ApiTarefas.Models;
using ApiTarefas.Repos;
using ApiTarefas.Repos.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiTarefas.Services
{
    public class UsuarioService : UsuariosRepositorio
    {
        public UsuarioService(SistemaTarefasDBcontext SistemaTarefasDBcontext) : base(SistemaTarefasDBcontext)
        {

        }

        public async Task<List<Usuario>> ListaUsuario()
        {
            var usuarios = await BuscarTodosUsuarios();
            return usuarios;
        }

        public async Task<Usuario> BuscarUsuarioExpecifico(int id)
        {
            var usuarios = await buscarporid(id);
            return usuarios;
        }

        public async Task<Usuario> AdicionarUsuario(Usuario usuario)
        {
            var usuarios = await Add(usuario);
            return usuarios;
        }

        public async Task<Usuario> AtualizarUsuario(int id, Usuario usuario)
        {
            var usuarios = await buscarporid(id);
            usuarios.nome = usuario.nome ; 
            usuarios.email = usuario.email;
            var usuarioss = await Atualizar(usuarios);
            return usuarioss;
        }

        public async Task<bool> ApagarUsuario(int id) 
        {
            var usuarios = await buscarporid(id);

            if (usuarios == null)
            {
                throw new Exception($"O usuario {id} Não foi Encontrado.");
            }
            
            var usuarioss = await Apagar(usuarios);
            return true;

        }


    }
}
