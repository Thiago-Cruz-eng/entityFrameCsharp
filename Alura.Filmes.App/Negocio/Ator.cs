using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Alura.Filmes.App.Negocio
{
    [Table("Actor")]
    internal class Ator
    {
        [Column("actor_id")]
        public int Id { get; set; }

        [Required]
        [Column("first_name", TypeName = "varchar(45)")]
        public string PrimeiroName { get; set; }
        
        [Required]
        [Column("last_name", TypeName = "varchar(45)")]
        public string UltimoName { get; set; }

        public override string ToString()
        {
            return $"Ator ({Id}): {PrimeiroName} {UltimoName}";
        }
    }
}
