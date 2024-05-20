using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp.Fila.Exercicio
{
    public class Ticket
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public string Prioridade { get; set; }

         public Ticket(int id, string descricao, string prioridade) 
        {
            this.Id = id;
            this.Descricao = descricao;
            this.Prioridade = prioridade;
        }
    }

}