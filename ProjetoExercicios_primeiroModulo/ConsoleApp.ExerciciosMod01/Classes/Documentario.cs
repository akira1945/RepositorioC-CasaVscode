using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp.ExerciciosMod01.Classes
{
    public class Documentario : ItemLocadora 
    {
        public string Assunto { get; set; }

        public Documentario(int codigo, string titulo, int ano, string assunto ) : base(codigo, titulo, ano)
        {
            this.Assunto = assunto;
        }

        public override void ExibirDetalhes()
        {
            Console.WriteLine($"Documentario: {titulo} \n Codigo para locação: {codigo} \n Ano lançamento:{ano} \n Assunto: {Assunto}");
        }
    }
}