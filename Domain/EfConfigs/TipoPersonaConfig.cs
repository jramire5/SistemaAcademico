using Domain.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
namespace Domain.EfConfigs;

public class TipoPersonaConfig : IEntityTypeConfiguration<TipoPersona>
{
    public void Configure(EntityTypeBuilder<TipoPersona> builder)
    {
        builder.HasKey(p => p.id_tipo);
        builder.Property(p => p.descripcion).HasMaxLength(50).IsRequired();
    } 
}
