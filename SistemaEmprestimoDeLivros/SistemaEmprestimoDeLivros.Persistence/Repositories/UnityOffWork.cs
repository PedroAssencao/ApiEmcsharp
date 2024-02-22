using SistemaEmprestimoDeLivros.Domain.Interfaces;
using SistemaEmprestimoDeLivros.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEmprestimoDeLivros.Persistence.Repositories
{
    public class UnityOffWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnityOffWork(AppDbContext context)
        {
            _context = context;
        }

        public async Task Commit(CancellationToken cancellationToken)
        {
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
