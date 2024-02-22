using AutoMapper;
using SistemaEmprestimoDeLivros.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEmprestimoDeLivros.Application.UseCases.CreateUser
{
    public sealed class CreateUserMapper : Profile
    {
        public CreateUserMapper()
        {
            CreateMap<CreateUserRequest, UserEntity>();
            CreateMap<UserEntity, CreateUserResponse>();
        }
    }
}
