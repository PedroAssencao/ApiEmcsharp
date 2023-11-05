using ConsumindoApi.Dtos;
using ConsumindoApi.Interfaces;
using ConsumindoApi.Models;
using System.Dynamic;
using System.Text.Json;

namespace ConsumindoApi.Rest
{
    public class BrasilApiRest : IBrasilApi
    {
        public async Task<ResponseGenerico<EnderecoModel>> BuscarEnderecoPorCEP(string cep)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/cep/v1/{cep}");

            var response = new ResponseGenerico<EnderecoModel>();

            using (var client = new HttpClient())
            {
                var responseBrasil = await client.SendAsync(request);
                var conteudoResp = await responseBrasil.Content.ReadAsStringAsync();
                var objetoResponse = JsonSerializer.Deserialize<EnderecoModel>(conteudoResp);

                if (responseBrasil.IsSuccessStatusCode)
                {
                    response.CodingHttp = responseBrasil.StatusCode;
                    response.DadosRetorno = objetoResponse;
                }
                else
                {
                    response.CodingHttp = responseBrasil.StatusCode;
                    response.ErrorRetorno = JsonSerializer.Deserialize<ExpandoObject>(conteudoResp);
                }

                return response;
            }

        }


        public Task<ResponseGenerico<List<BancoModel>>> BuscarTodosBanco()
        {
            throw new NotImplementedException();
        }


        public Task<ResponseGenerico<BancoModel>> BuscarBanco(string codigoBanco)
        {
            throw new NotImplementedException();
        }
    }
}
