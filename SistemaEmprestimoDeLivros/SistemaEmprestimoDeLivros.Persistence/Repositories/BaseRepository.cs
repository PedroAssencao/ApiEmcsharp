using Microsoft.EntityFrameworkCore;
using SistemaEmprestimoDeLivros.Domain.Entities;
using SistemaEmprestimoDeLivros.Domain.Interfaces;
using SistemaEmprestimoDeLivros.Persistence.Context;


namespace SistemaEmprestimoDeLivros.Persistence.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly AppDbContext _context;

        public BaseRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Create(T entity)
        {
            entity.DateCreated = DateTimeOffset.UtcNow;
            _context.Add(entity);
        }

        public void Delete(T entity)
        {
            entity.DateUpdated = DateTimeOffset.UtcNow;
            _context.Remove(entity);
        }

        public async Task<T> Get(Guid id, CancellationToken cancellationToken)
        {
            return await _context.Set<T>().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
        }

        public async Task<List<T>> GetAll(Guid id, CancellationToken cancellationToken)
        {
            return await _context.Set<T>().ToListAsync(cancellationToken);
        }

        public void Update(T entity)
        {
            entity.DateDeleted = DateTimeOffset.UtcNow;
            _context.Update(entity);
        }
    }
}
