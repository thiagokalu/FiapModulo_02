using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05.ExemploInterface.Services
{
    class EmailMessage : IMessage
    {
        public void EnviarMensagem(string mensagem)
        {


            if (mensagem.Length <5)
            {
                throw new Exception("Número de caracteres inválido");
            }

            Console.WriteLine($"Enviando o e-mail:{mensagem}"); 
        }
    }
}
