using ApiTarefas.Models;
using ApiTarefas.Repos;
using ApiTarefas.Repos.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiTarefas.Services
{
    public class UsuarioService
    {
        private readonly IUsuarioRepo _repository;

        public UsuarioService(IUsuarioRepo repository)
        {
            _repository = repository;
        }

        public async Task<Usuario> Atualizar(Usuario usuario, int id)
        {
            Usuario? UsuarioPorID = await _repository.BuscarPorID(id);

            if (UsuarioPorID == null)
            {
                throw new Exception($"O usuario {id} Não foi Encontrado.");
            }

            UsuarioPorID.nome = usuario.nome?.ToLower();
            UsuarioPorID.email = usuario.email?.ToLower() ?? throw new Exception();

            await _repository.Atualizar(usuario);
            return UsuarioPorID;
        }

        public async Task<bool> Apagar(int id)
        {
            Usuario? UsuarioPorID = await _repository.BuscarPorID(id);

            if (UsuarioPorID == null)
            {
                throw new Exception($"O usuario {id} Não foi Encontrado.");
            }

            await _repository.Apagar(UsuarioPorID);
            return true;
        }


    }
}
