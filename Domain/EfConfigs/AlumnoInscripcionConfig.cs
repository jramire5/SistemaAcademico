using Microsoft.EntityFrameworkCore;
using Domain.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Domain.EfConfigs;

public class AlumnoInscripcionConfig:IEntityTypeConfiguration<AlumnoInscripcion>
{
    public void Configure(EntityTypeBuilder<AlumnoInscripcion> builder)
    {
        builder.HasKey(p => p.id_inscripcion );
        builder.Property(p=>p.id_condicion).IsRequired();
        builder.Property(p => p.id_alumno).IsRequired();
        builder.Property(p => p.id_curso).IsRequired();
        builder.Property(p => p.nota).IsRequired();
    }  
}
