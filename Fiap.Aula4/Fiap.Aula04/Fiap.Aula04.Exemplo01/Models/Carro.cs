using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula04.Exemplo01.Models
{
    public class Carro
    {
        //propriedades
        public string Modelo { get; set; }
        public int Ano { get; set; }
        //construtores _> sem retorno e mesmo nome da classa 
        public Carro(string modelo)
        {
            Modelo = modelo;

        }
        public Carro(string modelo, int ano)
        {
            Modelo = modelo;
            Ano = ano;
        }
        
    }
}
