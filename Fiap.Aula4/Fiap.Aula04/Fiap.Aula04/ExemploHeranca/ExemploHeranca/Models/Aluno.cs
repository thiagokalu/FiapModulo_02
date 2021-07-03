using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHeranca.Models
{
    //ALuno herda de pessoa (o aluno possui os atributos e metodos de pessoa
    public class Aluno : Pessoa
    {
      public int Matricula { get; set; }
        public string Curso { get; set; }

        public void ObterPresenca()
        {
            Console.WriteLine($"Aluno {Nome} presente");
        }
    }
}
