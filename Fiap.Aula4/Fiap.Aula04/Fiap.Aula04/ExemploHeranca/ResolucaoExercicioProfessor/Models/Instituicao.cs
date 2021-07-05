using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolucaoExercicioProfessor.Models
{
     class Instituicao
    {
        //propriedade

        public string Nome { get; set; }

        //Este é o construtor
        public Instituicao(string nome)
        {
            Nome = nome;
        }
    }
}
