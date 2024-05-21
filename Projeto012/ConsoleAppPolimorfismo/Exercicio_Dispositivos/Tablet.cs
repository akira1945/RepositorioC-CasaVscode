using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleAppPolimorfismo
{
    public class Tablet(string marca, string modelo, int ano, double tamanho, int capacidadeTablet) : DipositivosEletronico(marca, modelo, ano)
    {
        public double tamanhoDeTela { get; set; } = tamanho;

        public int capacidadeBateriaTablet { get; set; } = capacidadeTablet;

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