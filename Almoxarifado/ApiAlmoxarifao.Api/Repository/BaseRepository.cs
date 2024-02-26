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

        public List<T> GetAll() => _context.Set<T>().ToList();

        public async Task<T> Adicionar(T Model)
        {
            _context.AddAsync(Model);
            _context.SaveChanges();
            return Model;
        }

    }
}
