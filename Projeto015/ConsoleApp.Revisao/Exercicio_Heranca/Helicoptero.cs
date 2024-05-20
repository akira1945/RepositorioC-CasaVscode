using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp.Revisao.Exercicio_Heranca
{
    public class Helicoptero : Aeronaves
    {
        private int QuantidadePasRotor;
        public Helicoptero(string tipo, string fabricante, string utilizacao, int ano, int quantidade) : base(tipo, fabricante, utilizacao, ano)
        {
            this.QuantidadePasRotor = quantidade;
        }

        public Helicoptero(string tipo, string fabricante, string utilizacao, int ano) : base(tipo, fabricante, utilizacao, ano)
        {
        }

        public int quantidadePasRotor { get{ return QuantidadePasRotor;} set{ QuantidadePasRotor = value; }}

        public void tipoHelicoptero(string tipo)
        {
            base.novoTipo(tipo);
        }

        public void fabricanteHelicopteroo( string fabricante)
        {
            base.novoFabricante( fabricante);
        }

        public void utilizacaoHelicoptero()
        {
            base.novaUtilizacao($"Utilizado para Salvamento.");
        }

         public void anoHelicoptero()
        {
            base.novoAno();
        }

        public void novaQtdPasRotor()
        {
            Console.WriteLine($"Total de pás dos rotores: {quantidadePasRotor}");
            
        }
    }
}