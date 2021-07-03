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
        }
        //Sobrescrevendo o metodo definido pelo pai (override)
        public override decimal CalcularDesconto()
        {
            return CalcularDesconto(90);
        }
        //sobrescrever o metodo desconto com cupom adicionando o cupom fiapbook com 30%
        public override decimal CalcularDesconto(string cupom)
        {
            return cupom == "FIAPBOOK" ? CalcularDesconto(30) : cupom == "FIAP10" ? CalcularDesconto(10) : Preco;
      
        }
    }
}
