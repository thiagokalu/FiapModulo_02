using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula04.ExemploHeranca3_Exercicio.Models
{
    public class Instituicao
    {
        public string Nome { get; set; }
        public Instituicao(string nome)

        {
            Nome = nome;
        }
    }
}