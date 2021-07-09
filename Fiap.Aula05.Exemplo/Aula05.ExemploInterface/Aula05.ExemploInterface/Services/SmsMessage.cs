using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05.ExemploInterface.Services
{
    class SmsMessage : IMessage
    {
        public void EnviarMensagem(string mensagem)
        {
            //validar se a mensagem tem menos de 10 char e lançar a mensagem

            if (mensagem.Length < 10)
                throw new MensagemInvalidaException("mensagem com menos de 10 caracteres");

            Console.WriteLine($"Enviando o sms:{mensagem}");
        }
    }
}
