using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp.Revisao.Exercicio_Heranca
{
    public class Aeronaves
    {
        private string Tipo;

        private string Fabricante;

        private string Utilizacao;

        private int Ano;

        public string tipo { get{ return Tipo; } set {Tipo = value;} }

        public string fabricante { get{return Fabricante;} set{ Fabricante =  value; } }

        public string utilizacao { get {return Utilizacao; } set {Utilizacao = value; }}

        public int ano { get { return Ano; } set { Ano = value; }}

        public Aeronaves( string tipo, string fabricante, string utilizacao, int ano)
        {
            this.Tipo = tipo;
            this.Fabricante = fabricante;
            this.Utilizacao = utilizacao;
            this.Ano = ano;
        }

        public string novoTipo( string tipoNovo ){

            Tipo= tipoNovo;
            return tipoNovo;
        }

        public string novoFabricante( string fabricanteNovo ){

            Fabricante = fabricanteNovo;
            return fabricanteNovo;
        }

        public virtual string novaUtilizacao( string utilizacaoNova )
        {
            if(utilizacaoNova == "M")
            {
                return $"Militar";
            
            }else{

                return $"Civil";
            }
            
        }

        public void novoAno(){

            Console.WriteLine($"Ano de fabricação da aeronave: {ano}");
        }

    }
}