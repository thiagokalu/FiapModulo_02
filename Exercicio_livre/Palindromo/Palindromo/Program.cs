using System;

namespace Palindromo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite um texto que será transformado em Palindromo");
            string texto = Console.ReadLine();

            char[] textoArray = texto.ToCharArray();
            char[] textoInvertido = new char[texto.Length];

            for (int i =0; 
                i < texto.Length; 
                i++)
            {
                textoInvertido[i] = textoArray[(texto.Length - i) - 1];
            }
            Console.WriteLine(textoInvertido);
        }
    }
}
