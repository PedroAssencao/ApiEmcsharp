using ApiTarefas.Models;

namespace ApiTarefas.Repos.Interfaces
{
    public interface IUsuarioRepo
    {
        Task<List<Usuario>> BuscarTodosUsuarios();
        Task<Usuario> BuscarPorID(int id);
        Task<Usuario> Adicionar(Usuario usuarios);
        Task<Usuario> Atualizar(Usuario usuario);
        Task<bool> Apagar(Usuario id);
    }
}
