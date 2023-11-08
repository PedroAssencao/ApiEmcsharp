using ApiTarefas.Data;
using ApiTarefas.Models;
using ApiTarefas.Repos.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiTarefas.Repos
{
    public class UsuariosRepositorio : BaseRepository<Usuario>, IUsuarioRepo
    {
     
        public async Task<Usuario?> BuscarPorID(int id)
        {
            return await buscarporid(id);
        }

        public async Task<List<Usuario>> BuscarTodosUsuarios()
        {
            return await BuscarTodosUsuarios();

        }
        public async Task<Usuario> Adicionar(Usuario usuarios)
        {
            await Add(usuarios);
            return usuarios;
        }

        public async Task<Usuario> Atualizar(Usuario usuario)
        {
            await Atualizar(usuario);
            return usuario;
        }

        public async Task<bool> Apagar(Usuario usuario)
        {
            await Apagar(usuario);
            return true;
        }
    }
}
