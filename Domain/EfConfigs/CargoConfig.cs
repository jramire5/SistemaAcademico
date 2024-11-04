using Domain.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
namespace Domain.EfConfigs;

public class CargoConfig : IEntityTypeConfiguration<Cargo>
{
    public void Configure(EntityTypeBuilder<Cargo> builder)
    {
        builder.HasKey(p => p.Id_Cargo);
        builder.Property(p => p.Descripcion).HasMaxLength(50).IsRequired();
    }
 
}
