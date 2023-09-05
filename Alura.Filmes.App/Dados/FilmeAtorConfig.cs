using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Alura.Filmes.App.Dados
{
    public class FilmeAtorConfig : IEntityTypeConfiguration<FilmeAtor>
    {
        public void Configure(EntityTypeBuilder<FilmeAtor> builder)
        {
            builder
                .ToTable("film_actor");

            builder
               .Property<int>("film_id")
               .IsRequired();

            builder
                .Property<int>("actor_id")
                .IsRequired();

            builder
                .Property<DateTime>("last_update")
                .IsRequired()
                .HasColumnType("datetime")
                .HasDefaultValueSql("getdate()");

            builder
                .HasKey("film_id", "actor_id");
        }
    }
}