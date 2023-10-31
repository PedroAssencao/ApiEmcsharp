using ApiTarefas.Data.Map;
using ApiTarefas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Win32.SafeHandles;

namespace ApiTarefas.Data
{
    public class SistemaTarefasDBcontext : DbContext
    {
        public SistemaTarefasDBcontext(DbContextOptions<SistemaTarefasDBcontext> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Tarefa> tarefas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new TarefaMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
