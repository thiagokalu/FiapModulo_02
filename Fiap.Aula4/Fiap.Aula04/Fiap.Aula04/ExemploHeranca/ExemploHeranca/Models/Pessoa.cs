using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHeranca.Models
{
    public class Pessoa
    {
        //Protected internal deixa as classes filhas e do mesmo projeto acessarem valores. 
        //Protected private -> classe e classes filhas dentro do mesmo projeto 
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string RetornarDados()
        {
            return $"Nome: {Nome}, Idade: {Idade}";
        }
    }
}
