using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp.ExerciciosMod01.Classes
{
    public class Locadora
    {
        List<ItemLocadora> locaveis;

        public Locadora()
        {
            locaveis = new List<ItemLocadora>();
        }

        public void AddItemLocadora(ItemLocadora locavel)
        {
            if(locavel.codigo > 0)
            {
                locaveis.Add(locavel);
                Console.WriteLine($"Item adicionado a lista de locação com sucesso: {locavel.codigo} / {locavel.titulo}.");
            }	
        }

        public void RemoveItemLocadora(int codigoRemover)
        {
            ItemLocadora locavel = locaveis.Find(l => l.codigo == codigoRemover);
            if(locavel != null)
            {
                locaveis.Remove(locavel);
                Console.WriteLine($"Item removida da lista de locação com sucesso: {codigoRemover} / {locavel.titulo}");
            }
            else
            {
                Console.WriteLine($"Item não encontrado. Valide o codigo {codigoRemover}");
            }
        }

        public void ListarItemLocadora()
        {   
            Console.WriteLine("Listando itens:");
            foreach (var listaItens in locaveis)
            {
                listaItens.ExibirDetalhes();
                Console.WriteLine();
            }

        }
    }
}