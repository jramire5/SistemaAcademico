using Domain.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
namespace Domain.EfConfigs;

public class PersonaConfig : IEntityTypeConfiguration<Persona>
{
    public void Configure(EntityTypeBuilder<Persona> builder)
    {
        builder.HasKey(p => p.id_persona);
        builder.Property(p => p.nombre).HasMaxLength(50).IsRequired();
        builder.Property(p => p.apellido).HasMaxLength(50).IsRequired();
        builder.Property(p => p.direccion).HasMaxLength(50).IsRequired();
        builder.Property(p => p.email).HasMaxLength(50).IsRequired();
        builder.Property(p => p.telefono).HasMaxLength(50).IsRequired();

        builder.Property(p => p.fecha_nacimiento).IsRequired();
        builder.Property(p => p.legajo).IsRequired();
        builder.Property(p => p.id_plan).IsRequired();
        builder.Property(p => p.tipo_persona).IsRequired();
    }
 
}
