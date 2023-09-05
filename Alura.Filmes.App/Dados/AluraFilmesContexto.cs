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
        public DbSet<FilmeAtor> Elenco { get; set; }
        public DbSet<Idiomas> Idiomas { get; set; }

        //2 passo vou overide onconfiguring
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=AluraFilmes;Trusted_connection=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AtorConfig());
            modelBuilder.ApplyConfiguration(new FilmConfig());
            modelBuilder.ApplyConfiguration(new FilmeAtorConfig());
            modelBuilder.ApplyConfiguration(new IdiomasConfig());
        }
    }
}
