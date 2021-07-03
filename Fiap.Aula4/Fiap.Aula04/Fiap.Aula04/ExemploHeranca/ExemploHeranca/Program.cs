using ExemploHeranca.Models;
using System;

namespace ExemploHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar um aluno

            var aluno = new Aluno(nome: "Thalita", matricula:123);


            //Atribuir o nome pro aluno 
            aluno.Nome = "Thalita";
            aluno.Matricula = 123 ;

            var pessoa = new Pessoa("Ricardo");
            //pessoa.Nome = "Ricardo";

            //chamar o metodo retornar dados
            Console.WriteLine(aluno.RetornarDados());
            Console.WriteLine(pessoa.RetornarDados());

            aluno.ObterPresenca();
        }
    }
}
