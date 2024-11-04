using Domain.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
namespace Domain.EfConfigs;

public class CondicionConfig : IEntityTypeConfiguration<Condicion>
{
    public void Configure(EntityTypeBuilder<Condicion> builder)
    {
        builder.HasKey(p => p.Id_Condicion);
        builder.Property(p => p.Descripcion).HasMaxLength(50).IsRequired();
    }
 
}
