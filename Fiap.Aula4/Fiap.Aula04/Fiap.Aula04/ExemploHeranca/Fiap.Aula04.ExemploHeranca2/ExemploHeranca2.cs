using ExemploHeranca.Models;
using System;

namespace Fiap.Aula04.ExemploHeranca2
{
    class ExemploHeranca2
    {
        static void Main(string[] args)
        {
            //instanciar um aluno do outro projeto
            var aluno = new Aluno(matricula:123, nome:"felipe");
            //aluno.Nome = "Jose";
            //aluno.Idade = 18;
        }
    }
}
