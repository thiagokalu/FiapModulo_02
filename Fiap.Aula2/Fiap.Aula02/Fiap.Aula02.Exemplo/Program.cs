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
            notebook.Nome = "Dell XPS";
            notebook.Valor = 1000;



            Fabricante fabricante = new Fabricante();
            fabricante.Nome = "Dell";


            notebook.Fabricante= new Fabricante();

            notebook.Fabricante = fabricante;

            Console.WriteLine(notebook.Id);
            Console.WriteLine($"{notebook.Fabricante.Nome} está ativo: {notebook.Fabricante.Ativo}");

            Produto mouse = new Produto();
            mouse.Nome = "Multilaser";
            
        }
    }
}
