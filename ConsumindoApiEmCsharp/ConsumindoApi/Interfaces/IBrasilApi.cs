using ConsumindoApi.Dtos;
using ConsumindoApi.Models;

namespace ConsumindoApi.Interfaces
{
    public interface IBrasilApi
    {
        Task<ResponseGenerico<EnderecoModel>> BuscarEnderecoPorCEP(string cep);
        Task<ResponseGenerico<List<BancoModel>>> BuscarTodosBanco();

        Task<ResponseGenerico<BancoModel>> BuscarBanco(string codigoBanco);
    }
}
