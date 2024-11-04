using Domain.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
namespace Domain.EfConfigs;

public class PlanConfig : IEntityTypeConfiguration<Plan>
{
    public void Configure(EntityTypeBuilder<Plan> builder)
    {
        builder.HasKey(p => p.id_plan);
        builder.Property(p => p.desc_plan).HasMaxLength(50).IsRequired();
        builder.Property(p => p.id_especialidad).IsRequired();
        builder.Property(p => p.id_plan).IsRequired();
    }
 
}
