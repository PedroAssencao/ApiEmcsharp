using ApiTarefas.Models;

namespace ApiTarefas.Repos.Interfaces
{
    public interface ITarefaRepo
    {
        Task<List<Tarefa>> BuscarTodasTarefas();
        Task<Tarefa> BuscarPorID(int id);
        Task<Tarefa> Adicionar(Tarefa Tarefa);
        Task<Tarefa> Atualizar(Tarefa Tarefa, int id);
        Task<bool> Apagar(int id);
    }
}
