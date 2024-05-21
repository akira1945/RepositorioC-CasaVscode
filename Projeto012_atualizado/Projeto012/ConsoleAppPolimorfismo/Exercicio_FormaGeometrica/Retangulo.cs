using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ConsoleAppPolimorfismo.Exercicio_FormaGeometrica
{
    public class Retangulo : Forma
    {
        public double Largura { get; set; }

        public double Comprimento { get; set; }

        public double Area { get; set; }


        //Construtor

        public Retangulo(double largura, double comprimento)
        {
            Largura = largura;
            Comprimento = comprimento;
            Area = Largura * Comprimento / 2;
        }

        public void CalculaArea(){
            Console.WriteLine($"Area do retangulo é {Area}");
            }
            
     
        public override void Desenhar(){
            Console.WriteLine($"Essa é meu retangulo, sua Largura é {Largura}, e seu Comprimento é {Comprimento}, com area de {Area} .");
        }
    }
}