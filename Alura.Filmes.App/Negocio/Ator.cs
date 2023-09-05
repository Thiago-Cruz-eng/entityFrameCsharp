using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Alura.Filmes.App.Negocio
{
    public class Ator
    {
        public int Id { get; set; }

        public string PrimeiroName { get; set; }
        
        public string UltimoName { get; set; }
        public IList<FilmeAtor> Filmografia { get; set; }

        public Ator()
        {
            Filmografia = new List<FilmeAtor>();
        }
        public override string ToString()
        {
            return $"Ator ({Id}): {PrimeiroName} {UltimoName}";
        }
    }
}
