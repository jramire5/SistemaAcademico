using Domain.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
namespace Domain.EfConfigs;

public class ModuloUsuarioConfig : IEntityTypeConfiguration<ModuloUsuario>
{
    public void Configure(EntityTypeBuilder<ModuloUsuario> builder)
    {
        builder.HasKey(p => p.IdModuloUsuario);
        builder.Property(p => p.IdModulo).IsRequired();
        builder.Property(p => p.IdUsuario).HasMaxLength(50).IsRequired();
    }
}
