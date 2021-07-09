using Fiap.Aula05.Exemplo.Models;
using System;

namespace Fiap.Aula05.Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar uma pessoa fisica e atribuir um valor para o sexo 
            var pf = new PessoaFisica()
            {
                Nome = "Ricardo",
                Sexo = Genero.Masculino
            };

            //validar se o sexo é feminio
            if (pf.Sexo == Genero.Feminino)
                Console.WriteLine("O genero é feminino");
            else
                Console.WriteLine( "o sexo não é feminino");
            //exibir o valor 
            Console.WriteLine($"sexo digitado foi {pf.Sexo}");
            Console.WriteLine((int) pf.Sexo); // exibe o valor/posição da constante
        }
    }
}
