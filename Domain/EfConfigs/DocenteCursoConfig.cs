using Domain.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
namespace Domain.EfConfigs;

public class DocenteCursoConfig : IEntityTypeConfiguration<DocenteCurso>
{
    public void Configure(EntityTypeBuilder<DocenteCurso> builder)
    {
        builder.HasKey(p => p.id_dictado);
        builder.Property(p => p.id_docente).IsRequired();
        builder.Property(p => p.id_curso).IsRequired();
    } 
}
