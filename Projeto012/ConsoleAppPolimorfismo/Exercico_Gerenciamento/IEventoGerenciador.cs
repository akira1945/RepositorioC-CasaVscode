using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleAppPolimorfismo.Exercico_Gerenciamento
{
    public interface IEventoGerenciador
    {
        void AdicionaEvento(Evento evento);
        void ListarEventos();
        
    }
}