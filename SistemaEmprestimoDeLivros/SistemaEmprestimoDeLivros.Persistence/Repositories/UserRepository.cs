using Microsoft.EntityFrameworkCore;
using SistemaEmprestimoDeLivros.Domain.Entities;
using SistemaEmprestimoDeLivros.Domain.Interfaces;
using SistemaEmprestimoDeLivros.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEmprestimoDeLivros.Persistence.Repositories
{
    public class UserRepository : BaseRepository<UserEntity>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<UserEntity> GetByEmail(string email, CancellationToken cancellationToken)
        {
            return await _context.Users.FirstOrDefaultAsync(x => x.Email == email, cancellationToken);
        }
    }
}
