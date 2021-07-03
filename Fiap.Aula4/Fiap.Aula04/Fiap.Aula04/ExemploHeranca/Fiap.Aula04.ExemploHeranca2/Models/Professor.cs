using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHeranca.Models
{
    public class Professor : Pessoa
    {
        public string MateriaLecionada { get; set; }

        //Construtor invoicado

        //public Professor (string nome, int idade) : base(nome,idade)
        //{
        //    Nome = nome;
        //}
        public void FazerChamada()
        {
            Console.WriteLine($"{Nome} está fazendo chamada");
        }
    }
}
