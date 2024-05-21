using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleAppPolimorfismo.Exercicio_Notificacoes
{
    public class SMSNotificacao : INotificacoes
    {
        void INotificacoes.Enviar(string texto) {
           
            Console.WriteLine($"Enviar notificação por SMS {texto}");
        }
    }
}