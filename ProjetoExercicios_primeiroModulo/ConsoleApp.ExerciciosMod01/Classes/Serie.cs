using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace ConsoleApp.ExerciciosMod01.Classes
{
    public class Serie : ItemLocadora
    {
         public int Temporada { get; set; }

        public int Epsodios { get; set; }


        public Serie(int codigo, string titulo, int ano, int temporada, int epsodios) : base(codigo, titulo, ano)
        {
            this.Temporada = temporada;
            this.Epsodios  = epsodios;
        }

    
        public override void ExibirDetalhes()
        {
            Console.WriteLine($"Serie: {titulo} \n Codigo para locação: {codigo} \n Ano lançamento:{ano} \n Quantidade de Temporadas: {Temporada} \n Total de epsodios: {Epsodios}");
        }

        public void duracaoSerie(Filme filme)
        {
            Console.WriteLine($"Duração total por epsodio: {filme.Duracao}");
        }

    }
}