using Microsoft.EntityFrameworkCore;
using Domain.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.EfConfigs;

public class MateriaConfig : IEntityTypeConfiguration<Materia>
{
    public void Configure(EntityTypeBuilder<Materia> builder)
    {
        builder.HasKey(p => p.id_materia);
        builder.Property(p => p.desc_materia).HasMaxLength(50).IsRequired();
        builder.Property(p => p.hs_semanales).IsRequired();
        builder.Property(p => p.hs_totales).IsRequired();
        builder.Property(p => p.id_plan).IsRequired();       

    }  
}
