using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp.ExerciciosMod01.Classes
{
    public class Filme : ItemLocadora
    {

        public string Diretor { get; set; } 

        public int Duracao { get; set; } = 0;
        
        
       
        public Filme(int codigo, string titulo, int ano, string diretor, int duracao) : base(codigo, titulo, ano)
        {
            this.Diretor = diretor;
            this.Duracao = duracao;
        }

        public override void ExibirDetalhes()
        {
          Console.WriteLine($"Filme: {titulo} \n Codigo para locação: {codigo} \n Ano lançamento:{ano} \n Dirigido: {Diretor} \n Com duração total: {Duracao}");
        }
    }
}