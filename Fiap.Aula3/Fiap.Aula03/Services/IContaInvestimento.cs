using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula03.Services
{
    public interface IContaInvestimento
    {
        decimal CalcularRetornoInvestimento(decimal taxa);
    }
}
