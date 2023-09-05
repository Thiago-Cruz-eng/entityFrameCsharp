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
          

                var elenco = context.Elenco;

                foreach (var e in elenco)
                {
                    var entity = context.Entry(e);
                    var film = entity.Property("film_id").CurrentValue;
                    var actor = entity.Property("actor_id").CurrentValue;
                    var date = entity.Property("last_update").CurrentValue;
                    Console.WriteLine($"film {film}, actor: {actor}, date: {date}");
                }


                /* 
                 * ADD NEW ACTOR
                   var ator = new Ator();
                   ator.PrimeiroName = "Nardo";
                   ator.UltimoName = "Cruz";

                context.Atores.Add(ator);
                context.SaveChanges();*/

                /*//listar 10 ultimos updates no DB
                  var atores = context.Atores
                      .OrderByDescending(a => EF.Property<DateTime>(a, "last_update"))
                      .Take(10);
                  //LISTAR
                  foreach( var a in atores )
                  {
                      Console.WriteLine(a + "---" + context.Entry(a).Property("last_update").CurrentValue);
                 }*/
            }

        }
    }
}