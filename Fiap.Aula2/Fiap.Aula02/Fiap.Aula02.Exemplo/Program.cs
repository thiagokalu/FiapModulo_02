using Fiap.Aula02.Exemplo.Models;
using System;

namespace Fiap.Aula02.Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto notebook = new Produto();
            notebook.Id = 10;
            Fabricante fabricante = new Fabricante();
            notebook.Nome = "Dell XPS";
            notebook.Valor = 1000;
            notebook.Fabricante= new Fabricante();
            notebook.Fabricante.Nome = "Dell";
            Console.WriteLine(notebook.Id);
            notebook.Fabricante = fabricante;

            Produto mouse = new Produto();
        }
    }
}
