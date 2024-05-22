using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp.ExerciciosMod01.Classes
{
    public class Usuario
    {
        public string Nome { get; set; }

        public int  Id { get; set; }

        public Usuario(string nome, int id)
        {
            this.Nome = nome;
            this.Id = id;
        }

        //metodo abstrato
        public abstract void ExibirDetalhesUsuario();
    }
}
