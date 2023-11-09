using ApiTarefas.Data;
using ApiTarefas.Models;
using ApiTarefas.Repos.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace ApiTarefas.Repos
{
    public class BaseRepository<TModel> where TModel : class
    {
        protected readonly SistemaTarefasDBcontext _context;
        public BaseRepository(SistemaTarefasDBcontext SistemaTarefasDBcontext)
        {
            _context = SistemaTarefasDBcontext;
        }

        public async Task<TModel> Add(TModel model)
        {
            await _context.AddAsync(model);
            await _context.SaveChangesAsync();
            return model;
        }

        public async Task<bool> Apagar(Usuario usuario)
        {
            _context.Remove(usuario);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<TModel> Atualizar(TModel TModel)
        {
            _context.Update(TModel);
            await _context.SaveChangesAsync();
            return TModel;
        }

  
        public Task<List<TModel>> BuscarTodosUsuarios()
        {
            return Task.Run(() => _context.Set<TModel>().ToListAsync().Result);
        }

        public async Task<TModel?> buscarporid(int id)
        {

            return await _context.Set<TModel>().FindAsync(id);

        }

    }
}
