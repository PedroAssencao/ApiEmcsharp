using concessionária.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace concessionária.Data.Map
{
    public class CarrosMap : IEntityTypeConfiguration<Carros>
    {

        public void Configure(EntityTypeBuilder<Carros> Carros)
        {
            Carros.HasKey(x => x.car_id);
            Carros.Property(x => x.car_name).IsRequired().HasMaxLength(255);
            Carros.Property(x => x.car_cor).IsRequired().HasMaxLength(255);
            Carros.Property(x => x.car_modelo).IsRequired().HasMaxLength(255);
        }
    }
}
