using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Alura.Filmes.App.Dados
{
    public class IdiomasConfig : IEntityTypeConfiguration<Idiomas>
    {
        public void Configure(EntityTypeBuilder<Idiomas> builder)
        {
            builder
                .ToTable("language");

            builder
                .Property(i => i.Id)
                .HasColumnName("language_id");

            builder
                .Property(i => i.Nome)
                .HasColumnName("name")
                .HasColumnType("char(20)")
                .IsRequired();

            builder
                .Property<DateTime>("last_update")
                .HasColumnType("datetime")
                .HasDefaultValueSql("getdate()")
                .IsRequired();
        }
    }
}