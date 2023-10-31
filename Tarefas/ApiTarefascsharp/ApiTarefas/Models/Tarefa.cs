using ApiTarefas.Enums;
using Microsoft.AspNetCore.Identity;

namespace ApiTarefas.Models
{
    public class Tarefa
    {
        public int id { get; set; }
        public string? nome { get; set; }
        public string? descricao { get; set; }
        public StatusTarefa Status { get; set; }
        public int? usuarioID { get; set; }

        public virtual Usuario? usuario { get; set; } 
    }
}
