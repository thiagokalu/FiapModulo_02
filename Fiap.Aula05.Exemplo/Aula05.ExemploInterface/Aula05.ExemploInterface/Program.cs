using Aula05.ExemploInterface.Services;
using System;

namespace Aula05.ExemploInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            //tratamento de exception
            try{
            //ler um numero 
            Console.WriteLine("Digite um número");
            var numero = int.Parse(Console.ReadLine());
            }
            catch(Exception)
            {
                Console.WriteLine("Número Inválido");
            }
     
            finally
            {
                Console.WriteLine("Sempre Executa");
            }
            //ler a msg
            Console.WriteLine("Digite a mensagem");
            var msg = Console.ReadLine();
            //instanciar um email message
            IMessage message = new SmsMessage();

            try { 
            //chamar o metodo de enviar a mensagem
            message.EnviarMensagem(msg);
            }
            catch (MensagemInvalidaException e)
            {
                //exibe a mensagem definida no lançamento da exception
                Console.WriteLine(e.Message);
            }
        }
    }
}
