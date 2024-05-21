using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleAppPolimorfismo
{
    public class Smartphone : DipositivosEletronico
    {
        public string sistemasOperacionais { get; set; }

        public int capacidadeBateria { get; set; }

        
        public Smartphone(string marca, string modelo, int ano, string os, int capacidade) : base(marca, modelo, ano)
        {
            sistemasOperacionais = os;
            capacidadeBateria = capacidade;

        }

        
        public override void Ligar() {
            Console.WriteLine($"Ligando smartphone {Modelo} e OS {sistemasOperacionais}");
        }

        public override void Desligar() {
            Console.WriteLine($"Desligando smartphone {Modelo} e OS {sistemasOperacionais}");
        }

        //Metodo

        public void marcaSmartphone(){

            base.novaMarca();
        }

        public void modeloSmartphone (){

            base.novoModelo();
        }

        public void anoSmartphone(){

            base.anoFabricado();
        }

        public string osSmartphone( string novoOsSmatphone ){

            return( novoOsSmatphone = sistemasOperacionais);
        }

        // Sobrescrever metodo
        public override string ObterDescricao() { 
            
            base.ObterDescricao();
                return $"Descrição obtida {sistemasOperacionais} ";
        }

        public override int VerificaBateria() {

            base.VerificaBateria();
                return capacidadeBateria;
        }
    }
}