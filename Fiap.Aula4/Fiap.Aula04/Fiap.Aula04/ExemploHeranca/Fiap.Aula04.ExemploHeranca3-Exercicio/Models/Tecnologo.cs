using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula04.ExemploHeranca3_Exercicio.Models
{
    public class Tecnologo : Formacao
    {
        public bool PlanoEstendido { get; set; }

        public Tecnologo(string nome): base(nome)
        {
        }

        public override decimal CalcularMensalidade()
        {
            DefinirDuracao();
            return Mensalidade = Duracao * 500;
        }
    }
}
