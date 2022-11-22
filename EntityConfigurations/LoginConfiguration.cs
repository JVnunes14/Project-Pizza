using VoeAirlines.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VoeAirlines.EntityConfigurations;

public class LoginConfiguration : IEntityTypeConfiguration<Login> 
{

    public void Configure(EntityTypeBuilder<Login> builder) 
    {
        
        builder.ToTable("Login");

        builder.HasKey(l => l.Id);

        builder.Property(l => l.Usuario)
               .IsRequired()
               .HasMaxLength(100);

        builder.Property(l => l.Senha)
               .IsRequired()
               .HasMaxLength(10);
    }
}
