using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp.Fila.Exercicio
{
    public class GerenciadorDeTickets 
    {
       public Queue<Ticket> filaAlta = new Queue<Ticket>();

       public Queue<Ticket> filaMedia = new Queue<Ticket>();  

       public Queue<Ticket> filaBaixa = new Queue<Ticket>();


        //Metodo para Adicionar Ticket.
        public void AdicionarTicket(Ticket ticket)
        {

            if (ticket.Prioridade == "Alta") 
            { 
                 filaAlta.Enqueue(ticket);
            }
            else if (ticket.Prioridade == "Media")  
            {
                filaMedia.Enqueue(ticket);
            }
            else if (ticket.Prioridade == "Baixa" )
            {
                filaBaixa.Enqueue(ticket);
            }
        }

        //Metodo Resolver Ticket
        
        public void ResolverTicket()
        {   
            if(filaAlta.Count > 0)
            {
                var itemAlta = filaAlta.Dequeue();
                Console.WriteLine($"Resolvendo Tickets de Alta  Prioridade : {itemAlta.Descricao}");
                Thread.Sleep(4000);
            }
            else if(filaMedia.Count > 0)
            {
                var itemMedia = filaMedia.Dequeue();
                Console.WriteLine($"Resolvendo Tickets de Media Prioridade : {itemMedia.Descricao}");
                Thread.Sleep(4000);
            }
            else if (filaBaixa.Count >0) 
            {
                var itemBaixa = filaBaixa.Dequeue();
                Console.WriteLine($"Resolvendo Tickets de Baixa Prioridade : {itemBaixa.Descricao}");
                Thread.Sleep(4000);
            }
            
        }

        //Metodo Imprimir Ticket

        public void ImprimirTickets()
        {   
            if (filaAlta.Count > 0)
            {
            Console.WriteLine($"Tickets de Alta  Prioridade : {filaAlta.Count}");
            }
            else if (filaMedia.Count > 0)
            {
            Console.WriteLine($"Tickets de Media Prioridade : {filaMedia.Count}");
            }
            else if (filaBaixa.Count > 0)
            {
                 Console.WriteLine($"Tickets de Baixa Prioridade : {filaBaixa.Count}");
            }
            else if(filaBaixa.Count == 0 || filaMedia.Count == 0 || filaAlta.Count == 0)
            {
                Console.WriteLine($"   Fila Alta: {filaAlta.Count} \n   Fila Media: {filaMedia.Count} \n   Fila Baixa: {filaBaixa.Count}");
                Console.WriteLine("\nTodos os tickets estão resolvido!!!!");
            }
        }
    }
}