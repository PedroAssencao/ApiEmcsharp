using concessionária.Data.Map;
using concessionária.Models;
using Microsoft.EntityFrameworkCore;

namespace concessionária.Data
{
    public class ConssesionariaDbContext : DbContext
    {
        public ConssesionariaDbContext(DbContextOptions<ConssesionariaDbContext> options) : base(options)
        {
            
        }

        public DbSet<Carros> Carros { get; set; }
        public DbSet<Motos> Motos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CarrosMap());
            modelBuilder.ApplyConfiguration(new MotosMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
