using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleAppPolimorfismo.Exercico_Gerenciamento
{
    public class GerenciamentoEventos : IEventoGerenciador
    {

        private List<Evento> eventos = new List<Evento>();
        public GerenciamentoEventos()
        {
        }

        public DateTime AdicionarEvento { get; set; }

        //Metodos

        public void AdicionaEvento(string nome, DateTime data){

            Console.WriteLine($"Evento para {nome} no dia {data.ToShortDateString()}");
        }

        public string AdicionaEvento(string nome, string local, DateTime data)
        {
            return $"\n Evento para Sr(a) {nome}, ocorrerá no endereço:[ {local} ]. No dia {data.ToString()}";
        }

        public void AdicionaEvento(string nome, DateTime data, string descricao){
            Console.WriteLine($"Evento para {nome}, no dia {data}, teremos as seguintes opções: {descricao} ");
        }

        public void AdicionaEvento(Evento evento)
        {
            Console.WriteLine($"O evento será realizado {evento}") ;
        }

        public void ListarEventos() {
            
            foreach (Evento evento in eventos) {

                Console.WriteLine($"Evento: {evento.Nome} em {evento.Data.ToShortDateString()}");
            }
        }
    }

}