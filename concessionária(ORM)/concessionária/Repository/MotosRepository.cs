using concessionária.Data;
using concessionária.Models;

namespace concessionária.Repository
{
    public class MotosRepository : BaseRepository<Motos>
    {
        public MotosRepository(ConssesionariaDbContext Conexao) : base(Conexao)
        {
        }
    }
}
