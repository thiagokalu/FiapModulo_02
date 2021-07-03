using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHeranca3.Models
{
    public class Perecivel : Produto
    {
        public DateTime DataValidade { get; set; }
        

        public Perecivel (int id, string nome, DateTime dataValidade) : base (id,nome)
        {
            DataValidade = dataValidade;

        }
    }
}
