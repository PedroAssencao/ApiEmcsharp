using concessionária.Data;
using concessionária.Models;
using concessionária.Repository;

namespace concessionária.Services
{
    public class CarrosServices
    {
        private readonly CarrosRepository _repository;

        public CarrosServices(CarrosRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Carros>> ListaCarros()
        {
            var Carros = await _repository.BuscarTodos();
            return Carros;
        }

        public async Task<Carros> BuscarCarrosPorId(int id)
        {
            if (id == 0 || id == null)
            {
                throw new ArgumentNullException(nameof(id), "O ID não pode ser nulo.");
            }
            var Carros = await _repository.BuscarPorID(id);
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

            var Carros = await _repository.Add(Carro);
            return Carros;
        }


        public async Task<Carros> AtualizarCarros(int id, Carros carro)
        {
            if (carro == null)
            {
                throw new ArgumentNullException(nameof(carro.car_id), "O ID não pode ser nulo.");
            }
            var carroAT = await _repository.BuscarPorID(id);
            carroAT.car_name = carro.car_name;
            carroAT.car_modelo = carro.car_modelo;
            carroAT.car_cor = carro.car_cor;
            carroAT.car_img = carro.car_img;
            var Carros = await _repository.Atualizar(carroAT);
            return Carros;
        }


        public async Task<bool> ApagarCarro(int carro)
        {
            var CarroDeletado = await _repository.BuscarPorID(carro);

            if (CarroDeletado == null)
            {
                throw new ArgumentNullException(nameof(CarroDeletado.car_id), "O ID não pode ser nulo.");
            }

            try
            {
                var path = "wwwroot/" + CarroDeletado.car_img;
                System.IO.File.Delete(path);
                await _repository.Delete(CarroDeletado);
            }
            catch (Exception)
            {
               await _repository.Delete(CarroDeletado);
            }
            return true;
        }

        
    }
}
