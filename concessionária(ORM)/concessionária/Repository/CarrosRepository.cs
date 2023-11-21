using concessionária.Data;
using concessionária.Models;

namespace concessionária.Repository
{
    public class CarrosRepository : BaseRepository<Carros>
    {
        public CarrosRepository(ConssesionariaDbContext Conexao) : base(Conexao)
        {
        }
    }
}
