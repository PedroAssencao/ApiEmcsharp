using ApiTarefas.Data;
using ApiTarefas.Models;
using ApiTarefas.Repos.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiTarefas.Repos
{
    public class UsuariosRepositorio : IUsuarioRepo
    {
        private readonly SistemaTarefasDBcontext _context;
        public UsuariosRepositorio(SistemaTarefasDBcontext SistemaTarefasDBcontext)
        {
            _context = SistemaTarefasDBcontext;
        }

        public async Task<Usuario> BuscarPorID(int id)
        {
            return await _context.Usuarios.FirstOrDefaultAsync(x => x.id == id);
        }

        public async Task<List<Usuario>> BuscarTodosUsuarios()
        {
            return await _context.Usuarios.ToListAsync();

        }
        public async Task<Usuario> Adicionar(Usuario usuarios)
        {
            await _context.Usuarios.AddAsync(usuarios);
            await _context.SaveChangesAsync();

            return usuarios;
        }

        public async Task<Usuario> Atualizar(Usuario usuario, int id)
        {
            Usuario UsuarioPorID = await BuscarPorID(id);

            if (UsuarioPorID == null)
            {
                throw new Exception($"O usuario {id} Não foi Encontrado.");
            }

            UsuarioPorID.nome = usuario.nome;
            UsuarioPorID.email = usuario.email;

            _context.Usuarios.Update(UsuarioPorID);
            await _context.SaveChangesAsync();
            return UsuarioPorID;
        }

        public async Task<bool> Apagar(int id)
        {
            Usuario UsuarioPorID = await BuscarPorID(id);

            if (UsuarioPorID == null)
            {
                throw new Exception($"O usuario {id} Não foi Encontrado.");
            }

            _context.Usuarios.Remove(UsuarioPorID);
            await _context.SaveChangesAsync();
            return true;
        }

        

     
    }
}
