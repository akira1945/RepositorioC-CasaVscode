using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp.ExerciciosMod01.Classes
{
    public class GerenciadorUsuarios
    {
        List<Usuario> usuarios;

        public GerenciadorUsuarios()
        {
            usuarios = new List<Usuario>();
        }

        public void AddUsuario(Usuario usuario)
        {
            Usuario usu = usuarios.Find(u => u.Id == usuario.Id);
            if(usu != null)
            {
                usuarios.Add(usuario);
                Console.WriteLine($"Cliente adicionado com sucesso: {usuario.Id} / {usuario.Nome}");
            }
        }

        public void RemoverUsuario(int idUsuario)
        {
            Usuario usu = usuarios.Find(u => u.Id == idUsuario);
            if(usu != null)
            {
                usuarios.Remove(usu);
                Console.WriteLine($"Cliente adicionado com sucesso: {usu.Id} / {usu.Nome}");
            }
            else
            {
                Console.WriteLine($"Cliente não encontrado. Por favor, valide o Id: {usu.Id}");
            }

        }

        public void ListarUsuario()
        {
            foreach (var lista in usuarios)
            {
                lista.ExibirDetalhesUsuario();
                Console.WriteLine();                
            }
        }
        
    }
}