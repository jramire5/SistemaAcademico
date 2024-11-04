using Microsoft.EntityFrameworkCore;
using Domain.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.EfConfigs;

public class EspecialidadConfig : IEntityTypeConfiguration<Especialidad>
{
    public void Configure(EntityTypeBuilder<Especialidad> builder)
    {
        builder.HasKey(p => p.id_especialidad);
        builder.Property(p => p.desc_especialidad).HasMaxLength(50).IsRequired();
    }  
}
