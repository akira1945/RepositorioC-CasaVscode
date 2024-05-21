using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp.ExerciciosMod01.Classes
{
    public class ItemLocadora
    {
        private int Codigo;

        private string Titulo;

        private int Ano;
        public int codigo { get {return Codigo;} set{Codigo = value; } }

        public string titulo { get{return Titulo;}  set{Titulo = value;} } 

        public int ano { get{return Ano;} set{Ano = value;} }

        public ItemLocadora( int codigo, string titulo, int ano )
        {
            this.Ano = ano;
            this.Codigo = codigo;
            this.Titulo = titulo;            
        }
    }
}