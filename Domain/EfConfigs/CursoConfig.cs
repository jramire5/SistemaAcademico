using Microsoft.EntityFrameworkCore;
using Domain.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.EfConfigs;

public class CursoConfig : IEntityTypeConfiguration<Curso>
{
    public void Configure(EntityTypeBuilder<Curso> builder)
    {
        builder.HasKey(p => p.id_curso );
        builder.Property(p => p.id_materia).IsRequired();
        builder.Property(p => p.id_comision).IsRequired();
        builder.Property(p => p.anio_calendario).IsRequired();        
        builder.Property(p => p.cupo).IsRequired(); 
    }  
}
