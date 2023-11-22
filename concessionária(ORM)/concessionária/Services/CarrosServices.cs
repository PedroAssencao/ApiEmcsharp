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

        public async Task<Carros> AdicionarCarros(Carros Carro, IFormFile imagem)
        {
            if (Carro == null)
            {
                throw new ArgumentNullException(nameof(Carro.car_id), "O ID não pode ser nulo.");
            }

            if (imagem != null && imagem.Length > 0)
            {
                var filess = Directory.GetFiles($"wwwroot/img/Carros").Length + 1;
                string pathh = $"wwwroot/img/Carros/Carros-{filess + 1}.jpg";
                string path = $"/img/Carros/Carros-{filess + 1}.jpg";

                using (var stream = new FileStream(pathh, FileMode.Create))
                {
                    await imagem.CopyToAsync(stream);
                }

                Carro.car_img = path;
            }

            var Carros = await Add(Carro);
            return Carros;
        }


        public async Task<Carros> AtualizarCarros(int id, Carros carro)
        {
            if (carro == null)
            {
                throw new ArgumentNullException(nameof(carro.car_id), "O ID não pode ser nulo.");
            }
            var carroAT = await BuscarPorID(id);
            carroAT.car_name = carro.car_name;
            carroAT.car_modelo = carro.car_modelo;
            carroAT.car_cor = carro.car_cor;
            carroAT.car_img = carro.car_img;
            var Carros = await Atualizar(carroAT);
            return Carros;
        }


        public async Task<bool> ApagarCarro(int carro)
        {
            var CarroDeletado = await BuscarPorID(carro);

            if (CarroDeletado == null)
            {
                throw new ArgumentNullException(nameof(CarroDeletado.car_id), "O ID não pode ser nulo.");
            }

            try
            {
                var path = "wwwroot/" + CarroDeletado.car_img;
                System.IO.File.Delete(path);
                await Delete(CarroDeletado);
            }
            catch (Exception)
            {
               await Delete(CarroDeletado);
            }
            return true;
        }

        
    }
}
