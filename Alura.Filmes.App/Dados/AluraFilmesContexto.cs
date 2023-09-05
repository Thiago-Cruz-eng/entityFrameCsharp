using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;
using System;

namespace Alura.Filmes.App.Dados
{
    //1 passo amarrar o entity herdando o dbcontext
    internal class AluraFilmesContexto : DbContext
    {
        //3 passo amarrar a tabela que o entity vai gerenciar
        public DbSet<Ator> Atores { get; set; }
        public DbSet<Filme> Filmes { get; set; }

        //2 passo vou overide onconfiguring
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=AluraFilmes;Trusted_connection=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ator>()
                .ToTable("actor");

            modelBuilder.Entity<Ator>()
                .Property(a => a.Id)
                .HasColumnName("actor_id");

            modelBuilder.Entity<Ator>()
                .Property(a => a.PrimeiroName)
                .HasColumnName("first_name")
                .HasColumnType("varchar(45)")
                .IsRequired();

            modelBuilder.Entity<Ator>()
               .Property(a => a.UltimoName)
               .HasColumnName("last_name")
               .HasColumnType("varchar(45)")
               .IsRequired();

            modelBuilder.Entity<Ator>()
                .Property<DateTime>("last_update")
                .HasColumnType("datetime")
                .HasDefaultValueSql("getdate()")
                .IsRequired();
           
            modelBuilder.Entity<Filme>()
                .ToTable("film");

            modelBuilder.Entity<Filme>()
                .Property(a => a.Id)
                .HasColumnName("film_id");

            modelBuilder.Entity<Filme>()
                .Property(a => a.Titulo)
                .HasColumnName("title")
                .HasColumnType("varchar(255)")
                .IsRequired();

            modelBuilder.Entity<Filme>()
                .Property(a => a.Descricao)
                .HasColumnName("description")
                .HasColumnType("text");

            modelBuilder.Entity<Filme>()
                .Property(a => a.AnoLancamento)
                .HasColumnName("release_year")
                .HasColumnType("varchar(4)");

            modelBuilder.Entity<Filme>()
                .Property(f => f.Duracao)
                .HasColumnName("length");

            modelBuilder.Entity<Filme>()
                .Property<DateTime>("last_update")
                .HasColumnType("datetime")
                .HasDefaultValueSql("getdate()")
                .IsRequired();
        }
    }
}
