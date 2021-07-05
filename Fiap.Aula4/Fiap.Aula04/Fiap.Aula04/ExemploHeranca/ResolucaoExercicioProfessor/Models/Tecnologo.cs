using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolucaoExercicioProfessor.Models
{
     class Tecnologo : Formacao
    {
        //Propriedade
        public bool PlanoEstendido { get; set; }

      public Tecnologo(string nome ) : base(nome)
        {

        }
        public override decimal CalcularMensalidade()
        {
            return Mensalidade = 500 * Duracao;
        }
        
        protected override void DefinirDuracao()
        {
            Duracao = 24;
        }
        
    }
}
