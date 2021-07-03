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

        //o construtor filho tem que chamar o construtor pai 

        //construtor que invoca o construtor com nome da pessoa

        public Aluno(string nome, int idade, int matricula, string curso)
            : base(nome,idade)
        {
            Matricula = matricula;
            Curso = curso;
        }

        public Aluno (string nome, int matricula) : base(nome)
        {
            Matricula = matricula;
        }

        public void ObterPresenca()
        {
            Console.WriteLine($"Aluno {Nome} presente");
        }
    }
}
