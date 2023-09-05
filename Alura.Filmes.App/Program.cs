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
            using (var context = new AluraFilmesContexto())
            {
                context.LogSQLToConsole();

                var idiomas = context.Idiomas
                    .Include(i => i.FilmesFalados);

                foreach (var lang in idiomas)
                {
                    Console.WriteLine(lang);

                    foreach (var film in lang.FilmesFalados)
                    {
                        Console.WriteLine(film);
                    }

                    Console.WriteLine("");
                }
            }

        }
    }
}