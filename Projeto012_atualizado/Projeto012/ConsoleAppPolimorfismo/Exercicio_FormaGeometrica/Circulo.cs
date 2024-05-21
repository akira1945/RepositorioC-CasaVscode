using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleAppPolimorfismo.Exercicio_FormaGeometrica
{
    public class Circulo : Forma
    {   
        public double coordenadaX { get; set; }

        public double coordenadaY { get; set; } 

        public double Raio { get; set; }

        //Construtor
        public Circulo(double coordenadax, double coordenaday)
        {
            coordenadaX = coordenadax;
            coordenadaY = coordenaday;
            Raio = coordenadaX*coordenadaY;
        }

        public bool AreaCircunferencia () {

            double novaArea = Raio*Raio/3.14;

            return novaArea == Raio;
        }

        // Override
        public override void Desenhar(){
            Console.WriteLine($"Esta é minha circunferencia {Raio}");
        }
    }
}