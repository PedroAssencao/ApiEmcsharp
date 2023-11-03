using ApiTarefas.Data;
using ApiTarefas.Models;
using ApiTarefas.Repos.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiTarefas.Repos
{
    public class TarefaRepositorio : ITarefaRepo
    {
        private readonly SistemaTarefasDBcontext _context;
        public TarefaRepositorio(SistemaTarefasDBcontext SistemaTarefasDBcontext)
        {
            _context = SistemaTarefasDBcontext;
        }

        public async Task<Tarefa> BuscarPorID(int id)
        {
            return await _context.tarefas.Include(x => x.usuario).FirstOrDefaultAsync(x => x.id == id);
        }

        public async Task<List<Tarefa>> BuscarTodasTarefas()
        {
            return await _context.tarefas.Include(x => x.usuario).ToListAsync();

        }
        public async Task<Tarefa> Adicionar(Tarefa Tarefa)
        {
            await _context.tarefas.AddAsync(Tarefa);
            await _context.SaveChangesAsync();
            return Tarefa;
        }

        public async Task<Tarefa> Atualizar(Tarefa Tarefa, int id)
        {
            Tarefa TarefaPorID = await BuscarPorID(id);

            if (TarefaPorID == null)
            {
                throw new Exception($"A Tarefa {id} Não foi Encontrado.");
            }

            TarefaPorID.usuarioID = Tarefa.usuarioID;
            TarefaPorID.descricao = Tarefa.descricao;
            TarefaPorID.Status = Tarefa.Status;
            TarefaPorID.nome = Tarefa.nome;

            _context.tarefas.Update(TarefaPorID);
            await _context.SaveChangesAsync();
            return TarefaPorID;
        }

        public async Task<bool> Apagar(int id)
        {
            Tarefa TarefaPorID = await BuscarPorID(id);

            if (TarefaPorID == null)
            {
                throw new Exception($"A Tarefa {id} Não foi Encontrada.");
            }

            _context.tarefas.Remove(TarefaPorID);
            await _context.SaveChangesAsync();
            return true;
        }

        

     
    }
}
