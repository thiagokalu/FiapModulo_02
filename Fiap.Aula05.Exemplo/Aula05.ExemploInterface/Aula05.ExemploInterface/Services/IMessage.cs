using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05.ExemploInterface.Services
{
    //define o contrato, os métodos que a interface deve implementar
    interface IMessage
    {
        void EnviarMensagem(string mensagem);

    }
}
