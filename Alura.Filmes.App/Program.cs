using System;
using System.Linq;
using Alura.Filmes.App.Dados;
using Alura.Filmes.App.Extensions;
using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;

namespace Alura.Filmes.App
{
    class Program
    {
        static void Main(string[] args)
        {
            //teste basico (select em atores)
            using (var context = new AluraFilmesContexto())
            {
                context.LogSQLToConsole();

                var filme = context.Filmes
                    .Include(f => f.Atores)
                    .ThenInclude(fa => fa.Ator)
                    .First();

                Console.WriteLine(filme);
                Console.WriteLine("Elenco: ");

                foreach (var ator in filme.Atores)
                {
                    Console.WriteLine(ator.Ator);
                }
            }

        }
    }
}