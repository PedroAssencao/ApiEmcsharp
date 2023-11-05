using ConsumindoApi.Dtos;
using ConsumindoApi.Models;

namespace ConsumindoApi.Interfaces
{
    public interface IEnderecoService
    {
        Task<ResponseGenerico<EnderecoResponse>> BuscarEnderecoPorCEP(string cep);
    }
}
