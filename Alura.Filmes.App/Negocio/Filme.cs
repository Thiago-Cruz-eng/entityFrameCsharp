using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Filmes.App.Negocio
{
    public class Filme
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public short Duracao { get; set; }
        public string AnoLancamento { get; set; }
        public IList<FilmeAtor> Atores { get; set; }
        public Idiomas IdiomaFalado { get; set; }
        public Idiomas IdiomaOriginal { get; set; }

        public Filme()
        {
            Atores = new List<FilmeAtor>();
        }



        public override string ToString()
        {
            return "Titulo: " + Titulo + " Lancamento: " + AnoLancamento;
        }
    }
}
