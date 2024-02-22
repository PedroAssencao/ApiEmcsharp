using Microsoft.EntityFrameworkCore;
using SistemaEmprestimoDeLivros.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEmprestimoDeLivros.Persistence.Context
{
    public  class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
         
        public DbSet<UserEntity>? Users { get; set; }
    }
}
