using System.ComponentModel;

namespace ApiTarefas.Enums
{
    public enum StatusTarefa
    {
        [Description("A fazer")]
        AFazer = 1,
        [Description("Em Andanmento")]
        EmAndamento = 2,
        [Description("Concluido")]
        Concluidp = 3
    }
}
