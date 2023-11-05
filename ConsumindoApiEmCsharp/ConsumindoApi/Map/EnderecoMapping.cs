using AutoMapper;
using ConsumindoApi.Dtos;
using ConsumindoApi.Models;

namespace ConsumindoApi.Map
{
    public class EnderecoMapping : Profile
    {
        public EnderecoMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<EnderecoResponse, EnderecoModel>();
            CreateMap<EnderecoModel, EnderecoResponse>();  
        }
    }
}
