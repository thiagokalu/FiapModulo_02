using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula03.Models
{
    public class Cliente
    {
       public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }

        public Cliente(string nome, string cpf, string telefone)
        {
            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
         }
    }  
}
