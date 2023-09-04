﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Alura.Filmes.App.Negocio
{
    internal class Ator
    {
        public int Id { get; set; }

        public string PrimeiroName { get; set; }
        
        public string UltimoName { get; set; }

        public override string ToString()
        {
            return $"Ator ({Id}): {PrimeiroName} {UltimoName}";
        }
    }
}
