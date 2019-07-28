using GuideInvestimentos.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GuideInvestimentos.Infra_Dados.Mapeamentos
{
    public class AutorMap: IEntityTypeConfiguration<Autor>
    {
        public void Configure(EntityTypeBuilder<Autor> builder)
        {
            builder.ToTable("Autor");

            builder.HasKey(x => x.Id);

            builder.OwnsOne(x => x.Nome, config =>
            {
                config.Property(x => x.Texto)
                    .HasColumnName("Nome")
                    .HasColumnType("varchar(200)")
                    .IsRequired();
            });
        }
    }
}
