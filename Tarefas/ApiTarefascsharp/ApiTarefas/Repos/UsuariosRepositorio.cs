using ApiTarefas.Data;
using ApiTarefas.Models;
using ApiTarefas.Repos.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiTarefas.Repos
{
    public class UsuariosRepositorio : IUsuarioRepo
    {
        private readonly BaseRepository<Usuario> _context;
        public UsuariosRepositorio(BaseRepository<Usuario> SistemaTarefasDBcontext)
        {
            _context = SistemaTarefasDBcontext;
        }

        public async Task<Usuario?> BuscarPorID(int id)
        {
            return await _context.buscarporid(id);
        }

        public async Task<List<Usuario>> BuscarTodosUsuarios()
        {
            return await _context.BuscarTodosUsuarios();

        }
        public async Task<Usuario> Adicionar(Usuario usuarios)
        {
            await _context.Add(usuarios);
            return usuarios;
        }

        public async Task<Usuario> Atualizar(Usuario usuario)
        {
            await _context.Atualizar(usuario);
            return usuario;
        }

        public async Task<bool> Apagar(Usuario usuario)
        {
            await _context.Apagar(usuario);
            return true;
        }
    }
}
