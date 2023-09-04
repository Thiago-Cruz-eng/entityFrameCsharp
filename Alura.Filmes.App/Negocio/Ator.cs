using System.ComponentModel.DataAnnotations.Schema;

namespace Alura.Filmes.App.Negocio
{
    [Table("Actor")]
    internal class Ator
    {
        [Column("actor_id")]
        public int Id { get; set; } 
        [Column("first_name")]
        public string PrimeiroName { get; set; }
        [Column("last_name")]
        public string UltimoName { get; set; }

        public override string ToString()
        {
            return $"Ator ({Id}): {PrimeiroName} {UltimoName}";
        }
    }
}
