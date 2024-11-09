using Domain.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
namespace Domain.EfConfigs;

public class UsuarioConfig : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.HasKey(p => p.id_usuario);
        builder.Property(p => p.nombre_usuario).HasMaxLength(50).IsRequired();
        builder.Property(p => p.clave).HasMaxLength(50).IsRequired();
        builder.Property(p => p.nombre).HasMaxLength(50);
        builder.Property(p => p.apellido).HasMaxLength(50);
        builder.Property(p => p.email).HasMaxLength(50).IsRequired();


    }
 
}
