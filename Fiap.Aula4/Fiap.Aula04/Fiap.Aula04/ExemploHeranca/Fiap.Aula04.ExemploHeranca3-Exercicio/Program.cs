using Fiap.Aula04.ExemploHeranca3_Exercicio.Models;
using System;

namespace Fiap.Aula04.ExemploHeranca3_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            var tecnologo = new Tecnologo("Dev")
            {
                PlanoEstendido = false,
                Tecnologo = true,
                Bacharelado = false
            };
            var engenharia = new Bacharelado("engenharia mecanica,", 200)
            {
                ProjetoConclusao = "construir um car",
                Bacharelado = true,
                Tecnologo = false

            };
            var quimica = new Formacao("quimica")

            {
            };
            Console.WriteLine("Tecnologo");
            Console.WriteLine(tecnologo.CalcularMensalidade());
            Console.WriteLine(tecnologo.CalcularMedia(9, 6));
            Console.WriteLine(tecnologo.CalcularMedia(8, 7, 2));


            Console.WriteLine("Bachelado engenharia");
            Console.WriteLine(engenharia.CalcularMensalidade());
            Console.WriteLine(engenharia.CalcularMedia(9, 6));
            Console.WriteLine(engenharia.CalcularMedia(8, 7, 2));

            Console.WriteLine("Formacao Quimica");
            Console.WriteLine(quimica.CalcularMensalidade());
            Console.WriteLine(quimica.CalcularMedia(9, 6));
            Console.WriteLine(quimica.CalcularMedia(8, 7, 2));
        }
    }
}