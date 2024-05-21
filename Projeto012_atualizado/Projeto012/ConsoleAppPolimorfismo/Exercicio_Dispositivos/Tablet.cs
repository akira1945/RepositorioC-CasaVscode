using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleAppPolimorfismo
{
    public class Tablet : DipositivosEletronico
    {
        public double tamanhoDeTela { get; set; }

        public int capacidadeBateriaTablet { get; set; }

        //construtor

        public Tablet(string marca, string modelo, int ano, double tamanho, int capacidadeTablet ) : base(marca, modelo, ano)
        {
            tamanhoDeTela = tamanho;
            capacidadeBateriaTablet = capacidadeTablet;
        }

        
       public override void Ligar() {
            Console.WriteLine($"Ligando tablet {Modelo}");
        }

        public override void Desligar() {
            Console.WriteLine($"Desligando tablet {Modelo}");
        }

        // Metodos

        
        public void marcaTablet(){

            base.novaMarca();
        }

        public void modeloTablet (){

            base.novoModelo();
        }

        public void anoTablet(){

            base.anoFabricado();
        }
        public double tamanhoTela( double novoTamanhoTela ){

            return( novoTamanhoTela = tamanhoDeTela);

        }


        public override string ObterDescricao() {

             base.ObterDescricao();
               return $" Tamanho da tela do tablet : {tamanhoDeTela}";

        }

        public override int VerificaBateria() {
             
             base.VerificaBateria();
                return capacidadeBateriaTablet;
             
        }

    }
}