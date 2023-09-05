using System;
using Alura.Filmes.App.Dados;
using Alura.Filmes.App.Extensions;
using Alura.Filmes.App.Negocio;

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
                var ator = new Ator();
                ator.PrimeiroName = "Nardo";
                ator.UltimoName = "Cruz";
                //context.Entry(ator).Property("last_update").CurrentValue = DateTime.Now;

                context.Atores.Add(ator);
                context.SaveChanges();
            }

        }
    }
}