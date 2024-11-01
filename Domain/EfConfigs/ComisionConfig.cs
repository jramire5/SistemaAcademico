using Microsoft.EntityFrameworkCore;
using Domain.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.EfConfigs;

public class ComisionConfig : IEntityTypeConfiguration<Comision>
{
    public void Configure(EntityTypeBuilder<Comision> builder)
    {
        builder.HasKey(p => p.id_comision );
        builder.Property(p => p.desc_comision).HasMaxLength(50).IsRequired();
        builder.Property(p => p.anio_especialidad).IsRequired(); 
        builder.Property(p => p.id_plan).IsRequired(); 
    }  
}
