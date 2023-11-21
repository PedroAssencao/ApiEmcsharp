using concessionária.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace concessionária.Data.Map
{
    public class MotosMap : IEntityTypeConfiguration<Motos>
    {
        public void Configure(EntityTypeBuilder<Motos> builder)
        {
            builder.HasKey(x => x.mot_id);
            builder.Property(x => x.mot_name).HasMaxLength(255);
            builder.Property(x => x.mot_cor).HasMaxLength(255);
            builder.Property(x => x.mot_modelo).HasMaxLength(255);
        }
    }
}
