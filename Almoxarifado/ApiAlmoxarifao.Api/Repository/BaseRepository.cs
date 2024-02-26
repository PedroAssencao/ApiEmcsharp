using ApiAlmoxarifao.Api.DAL;
using Microsoft.EntityFrameworkCore;

namespace ApiAlmoxarifao.Api.Repository
{
    public class BaseRepository<T> where T : class
    {
        protected readonly AlmoxarifadoContext _context;

        public BaseRepository(AlmoxarifadoContext context)
        {
            _context = context;
        }

        public async Task<List<T>> GetAll() => await _context.Set<T>().ToListAsync();

        public async Task<T> Adicionar(T Model)
        {
            _context.AddAsync(Model);
            _context.SaveChanges();
            return Model;
        }

        public async Task<T> GetPorId(int id) => await _context.Set<T>().FindAsync(id);

        public async Task<bool> Delete(int id)
        {
            var a = await GetPorId(id);
            _context.Remove(a);
            return true;
        }

    }
}
