using concessionária.Data;
using concessionária.Models;
using concessionária.Repository;

namespace concessionária.Services
{
    public class CarrosServices : CarrosRepository
    {
        public CarrosServices(ConssesionariaDbContext Conexao) : base(Conexao)
        {
        }

        public async Task<List<Carros>> ListaCarros()
        {
            var Carros = await BuscarTodos();
            return Carros;
        }

        public async Task<Carros> BuscarCarrosPorId(int id)
        {
            if (id == 0 || id == null)
            {
                throw new ArgumentNullException(nameof(id), "O ID não pode ser nulo.");
            }
            var Carros = await BuscarPorID(id);
            return Carros;
        }

        public async Task<Carros> AdicionarCarros(Carros Carro)
        {
            if (Carro == null)
            {
                throw new ArgumentNullException(nameof(Carro.car_id), "O ID não pode ser nulo.");
            }
            var Carros = await Add(Carro);
            return Carros;
        }

        public async Task<Carros> AtualizarCarros(Carros carro)
        {
            if (carro == null)
            {
                throw new ArgumentNullException(nameof(carro.car_id), "O ID não pode ser nulo.");
            }
            var Carros = await Atualizar(carro);
            return Carros;
        }


        public async Task<bool> ApagarCarro(Carros carro)
        {
            if (carro == null)
            {
                throw new ArgumentNullException(nameof(carro.car_id), "O ID não pode ser nulo.");
            }
            var Carros = await Delete(carro);
            return true;
        }

        
    }
}
