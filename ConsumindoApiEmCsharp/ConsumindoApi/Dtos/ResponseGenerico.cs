using System.Dynamic;
using System.Net;

namespace ConsumindoApi.Dtos
{
    public class ResponseGenerico<T> where T : class
    {
        public HttpStatusCode CodingHttp { get; set; }

        public T? DadosRetorno { get; set; }
        public ExpandoObject? ErrorRetorno { get; set; }
    }
}
