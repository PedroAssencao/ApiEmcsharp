using ApiTarefas.Data;
using ApiTarefas.Models;
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

        public async Task<bool> Apagar(TModel TModel)
        {
            _context.Remove(TModel);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<TModel> Atualizar(TModel TModel)
        {
            _context.Update(TModel);
            await _context.SaveChangesAsync();
            return TModel;
        }

        public async Task<List<TModel>> BuscarTodosUsuarios()
        {
            return await _context.Set<TModel>().ToListAsync();


        }
        public async Task<TModel?> buscarporid(int id)
        {

            return await _context.Set<TModel>().FindAsync(id);

        }


    }

    //public class Batata : BaseRepository<Usuario>
    //{
    //    public void adicionar()
    //    {
    //        _context.Usuarios.Add(new Usuario());

    //        return null
    //    }
        
    //}

    //public class aaaa : BaseRepository<Tarefa>
    //{
    //}

    //public class exemplo
    //{
    //    private readonly Batata batata;
    //    public exemplo()
    //    {
    //        batata = new Batata();
    //        batata.Add()
    //    }
    //}
}
