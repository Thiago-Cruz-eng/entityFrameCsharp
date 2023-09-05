using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using System;

namespace Alura.Filmes.App.Dados
{
    internal class FilmConfig : IEntityTypeConfiguration<Filme>
    {
       public void Configure(EntityTypeBuilder<Filme> builder)
        {
            builder
            .ToTable("film");

            builder
                .Property(f => f.Id)
            .HasColumnName("film_id");

            builder
                .Property(f => f.Titulo)
                .HasColumnName("title")
                .HasColumnType("varchar(255)")
            .IsRequired();

            builder
                .Property(f => f.Descricao)
                .HasColumnName("description")
            .HasColumnType("text");

            builder
                .Property(f => f.AnoLancamento)
                .HasColumnName("release_year")
                .HasColumnType("varchar(4)");

            builder
                .Property(f => f.Duracao)
            .HasColumnName("length");

            builder
                .Property<DateTime>("last_update")
                .HasColumnType("datetime")
                .HasDefaultValueSql("getdate()")
                .IsRequired();
        }
    }
}