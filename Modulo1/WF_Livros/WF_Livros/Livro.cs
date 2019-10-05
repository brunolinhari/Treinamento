using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Livros
{
    public class Livro
    {
        public Livro(string titulo, string autor, DateTime dataLancamento, int numeroPaginas)
        {
            this.id = Guid.NewGuid();
            Titulo = titulo;
            Autor = autor;
            DataLancamento = dataLancamento;
            NumeroPaginas = numeroPaginas;
        }

        public Guid id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public DateTime DataLancamento { get; set; }
        public int NumeroPaginas { get; set; }
    }
}
