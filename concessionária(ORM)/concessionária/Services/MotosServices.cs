using concessionária.Data;
using concessionária.Models;
using concessionária.Repository;

namespace concessionária.Services
{
    public class MotosServices : MotosRepository
    {
        public MotosServices(ConssesionariaDbContext Conexao) : base(Conexao)
        {
        }

        public async Task<List<Motos>> ListaMotos()
        {
            var Motos = await BuscarTodos();
            return Motos;
        }

        public async Task<Motos> BuscarMotosPorId(int id)
        {
            if (id == 0 || id == null)
            {
                throw new ArgumentNullException(nameof(id), "O ID não pode ser nulo.");
            }
            var Motos = await BuscarPorID(id);
            return Motos;
        }

        public async Task<Motos> AdicionarMotos(Motos Motos)
        {
            if (Motos == null)
            {
                throw new ArgumentNullException(nameof(Motos.mot_id), "O ID não pode ser nulo.");
            }
            var Motoss = await Add(Motos);
            return Motoss;
        }

        public async Task<Motos> AtualizarCarros(Motos Motos)
        {
            if (Motos == null)
            {
                throw new ArgumentNullException(nameof(Motos.mot_id), "O ID não pode ser nulo.");
            }
            var Motoss = await Atualizar(Motos);
            return Motoss;
        }


        public async Task<bool> ApagarCarro(Motos Motos)
        {
            if (Motos == null)
            {
                throw new ArgumentNullException(nameof(Motos.mot_id), "O ID não pode ser nulo.");
            }
            var Motoss = await Delete(Motos);
            return true;
        }

        
    }
}
