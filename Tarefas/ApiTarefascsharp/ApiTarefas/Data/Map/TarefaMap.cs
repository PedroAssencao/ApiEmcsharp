using ApiTarefas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiTarefas.Data.Map
{
    public class TarefaMap : IEntityTypeConfiguration<Tarefa>
    {
        public void Configure(EntityTypeBuilder<Tarefa> builder)
        {
            builder.HasKey(x => x.id);
            builder.Property(x => x.nome).IsRequired().HasMaxLength(255);
            builder.Property(x => x.descricao).HasMaxLength(1000);
            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.usuarioID);
            builder.HasOne(x => x.usuario);

        }
    }
}
