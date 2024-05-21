using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Threading.Tasks;

namespace ConsoleAppPolimorfismo
{
    public abstract class DipositivosEletronico(string marca, string modelo, int ano)
    {
        public string Marca { get; set; } = marca;

        public string Modelo { get; set; } = modelo;

        public int anoDeFabricacao { get; set; } = ano;

        //Metodos abstratos

        public abstract void Ligar();
        public abstract void Desligar();

        //Metodos virtuais

        public virtual string ObterDescricao(){
            
            return$"Descrição do equipamento : {Marca} e {Modelo}";
        }

        public virtual int VerificaBateria(){

            return -1;
        }

        //Metodos publicos
        public  void novaMarca(){

            Console.WriteLine($"Marca do equipamento : {Marca}");
        }  
        
        public void novoModelo (){

            Console.WriteLine($"Modelo do equipamento : {Modelo}");
        }

        public void anoFabricado(){

            Console.WriteLine($"Ano de fabricação : {anoDeFabricacao}");
        }

    

      
    }
}