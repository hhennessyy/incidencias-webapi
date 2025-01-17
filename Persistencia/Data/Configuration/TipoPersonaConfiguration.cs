using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Dominio;

namespace Persistencia.Data.Configuration
{
    public class TipoPersonaConfiguration : IEntityTypeConfiguration<TipoPersona>
    {
        public void Configure(EntityTypeBuilder<TipoPersona> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("tipopersona");

            builder.HasKey(e => e.IdTipoPersona);
            builder.Property(e => e.IdTipoPersona);

            builder.Property(p => p.DescripcionTipoPersona)
            .IsRequired()
            .HasMaxLength(50);
        }
    }
}