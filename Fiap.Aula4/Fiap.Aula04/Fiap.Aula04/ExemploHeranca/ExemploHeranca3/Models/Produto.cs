using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHeranca3.Models
{
    public class Produto 
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        Fornecedor Fornecedor { get; set; }
        
        public Produto(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
        public decimal CalcularDesconto(decimal porcentagem)
        {
            return Preco - (Preco * porcentagem)/ 100;
        }
       
        //overload de metodo. Metodo com mesmo nome e parametros diferentes. 

        public virtual decimal CalcularDesconto()
        {
            //return Preco - (Preco * 0.05m);
            return CalcularDesconto(5);
        }
        public virtual decimal CalcularDesconto(string cupom)
        {
            return cupom == "FIAP10" ? CalcularDesconto(10) : Preco;
        }
    }
}
