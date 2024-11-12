using Domain.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
namespace Domain.EfConfigs;

public class NotaConfig : IEntityTypeConfiguration<Nota>
{
    public void Configure(EntityTypeBuilder<Nota> builder)
    {
        builder.HasKey(p => p.id_nota);
        builder.Property(p => p.id_dictado).IsRequired();
        builder.Property(p => p.id_inscripcion).IsRequired();
        builder.Property(p => p.descripcion).HasMaxLength(50).IsRequired();
    } 
}
