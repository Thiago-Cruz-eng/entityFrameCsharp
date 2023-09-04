using System;
using Alura.Filmes.App.Dados;

namespace Alura.Filmes.App
{
    class Program
    {
        static void Main(string[] args)
        {
            //teste basico (select em atores)
            using (var context = new AluraFilmesContexto())
            {
                foreach (var ator in context.Atores)
                {
                    Console.WriteLine(ator);
                }
            }

        }
    }
}