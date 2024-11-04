using Domain.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
namespace Domain.EfConfigs;

public class ModuloConfig : IEntityTypeConfiguration<Modulo>
{
    public void Configure(EntityTypeBuilder<Modulo> builder)
    {
        builder.HasKey(p => p.Id_modulo);
        builder.Property(p => p.descripcion_modulo).HasMaxLength(50).IsRequired();
        builder.Property(p => p.ejecuta).HasMaxLength(50).IsRequired();
    }
}
