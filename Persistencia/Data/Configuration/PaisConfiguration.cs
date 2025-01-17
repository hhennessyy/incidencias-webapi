using Microsoft.EntityFrameworkCore;
using Dominio;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class PaisConfiguration : IEntityTypeConfiguration<Pais>
    {
        public void Configure(EntityTypeBuilder<Pais> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("pais");

            builder.HasKey(e => e.IdPais);
            builder.Property(e => e.IdPais)
            .HasMaxLength(3);

            builder.Property(e => e.NombrePais)
            .IsRequired()
            .HasMaxLength(50);
        }
    }
}