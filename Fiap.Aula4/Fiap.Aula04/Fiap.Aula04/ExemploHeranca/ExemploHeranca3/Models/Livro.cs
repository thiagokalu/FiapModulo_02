using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHeranca3.Models
{
    public class Livro : Produto
    {

        //propriedades
        public string Autor { get; set; }
        public int NumeroPaginas { get; set; }
        public int AnoPublicacao { get; set; }
   

        public Livro (int id, string nome, string autor) : base(id,nome)
        {

            Autor = autor;
            Id = id;
            Nome = nome;
        }
    }
}
