using ApiTarefas.Models;
using ApiTarefas.Repos.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiTarefas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefaController : ControllerBase
    {
        private readonly ITarefaRepo _tarefaRepo;
        public TarefaController(ITarefaRepo TarefaRepo)
        {
            _tarefaRepo = TarefaRepo;
        }
        [HttpGet]
        public async Task <ActionResult<List<Tarefa>>> BuscarTodasTarefas()
        {
            List<Tarefa> tarefas =  await _tarefaRepo.BuscarTodasTarefas();
            return Ok(tarefas);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Tarefa>> BuscarPorId(int id)
        {
            Tarefa tarefas = await _tarefaRepo.BuscarPorID(id);
            return Ok(tarefas);
        }

        [HttpPost]
        public async Task<ActionResult<Tarefa>> Cadastrar([FromBody] Tarefa tarefa)
        {
            Tarefa tarefas = await _tarefaRepo.Adicionar(tarefa);
            return Ok(tarefas);
        }


        [HttpPut("{id}")]   
        public async Task<ActionResult<Tarefa>> Atualizar([FromBody] Tarefa Tarefa, int id)
        {
            Tarefa.id = id;
            Tarefa tarefas = await _tarefaRepo.Atualizar(Tarefa, id);
            return Ok(tarefas);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Tarefa>> Apagar(int id)
        {
       
            bool tarefas = await _tarefaRepo.Apagar(id);
            return Ok(tarefas);
        }


    }
}
