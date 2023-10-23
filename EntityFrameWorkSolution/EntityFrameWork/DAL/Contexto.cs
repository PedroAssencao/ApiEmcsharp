using EntityFrameWork.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameWork.DAL
{
    public class Contexto : DbContext
    {
        public Contexto( DbContextOptions<Contexto> options):base(options)
        {
            
        }

        public DbSet<Produto> produtos { get; set; }
    }
}
