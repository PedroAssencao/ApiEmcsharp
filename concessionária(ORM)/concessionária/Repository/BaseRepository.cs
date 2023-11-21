using concessionária.Data;
using Microsoft.EntityFrameworkCore;

namespace concessionária.Repository
{
    public class BaseRepository<Tmodel> where Tmodel : class
    {
        protected readonly ConssesionariaDbContext _context;

        public BaseRepository(ConssesionariaDbContext Conexao)
        {
            _context = Conexao;
        }

        public async Task<Tmodel> Add(Tmodel Model)
        {
            await _context.AddAsync(Model);
            await _context.SaveChangesAsync();
            return Model;
        }

        public async Task<bool> Delete(Tmodel model)
        {
            _context.Remove(model);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<Tmodel> Atualizar(Tmodel model)
        {
            _context.Update(model);
            await _context.SaveChangesAsync();
            return model;
        }

        public Task<List<Tmodel>> BuscarTodos()
        {
            return Task.Run(() => _context.Set<Tmodel>().ToListAsync().Result);
        }

        public async Task<Tmodel?> BuscarPorID(int model)
        {
            return await _context.Set<Tmodel>().FindAsync(model);
        }
    }
}
