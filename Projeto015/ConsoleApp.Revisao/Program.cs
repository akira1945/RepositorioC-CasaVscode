using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

//Herança - Criar padrões, não repetições. Ela não precisa ser tão granular.

// Classe abstrata - Objeto mais complexo, pode ter mais propriedades, mais metodos, ajuda a ter um melhor controle. Manipular objetos.

// Interface para mapear metodos ou ações; Padronizar comunicação  ou utilizar varias camadas com mesmo metodo.entre classes (Encapsula ou patronizar conjunto de metodos)Eu tenho quem Processa, comita

// Palavra Virtual - Pouco utilizado - Permite modificar implementação de um metodo.

// Override - Utilizavel quando não existe modificação na logica da palavra Virtual.

// fOR - Length-1 para sempre começar da posição 0 caso esteja trabalhando com Array  - WHILE - Utilizavel em uma lista que você sabe a quantidade de posições.

// DO WHILE - Primeiro valida o loop para chegar na codição.

// Array - Guardar informações no formato pilha - começa na posição 0 [,] utilizado para Arrays multidimensionais -  Formação de matrizes matematica.
// Array <> LIST - array sempre vai ter um tamanho exato.
//Array[indice] -- Acessar posição especifica, utilizado para adição e remoção.
//Array.Copy() -- Copiar um array.

// forEach- Utilizado mais com coleções - ele vai percorrer todas as posições de sua coleção.

// LIST - Listar varios itens em um programa.

//LINQ - 

// string opcao = "";


// while (opcao != "sair"){
//     Console.WriteLine("Selecione a opcao do menu: ");
//     opcao = Console.ReadLine();
//     switch(opcao){
//         case "1":
//         Console.WriteLine("opcao 1 selecionada!");
//         break;
//         default:
//         Console.WriteLine("opcao invalida!");
//         break;
//     }
// };


// string opcao = "";
// var carros = new string[1];


// while (opcao != "sair"){
//     Console.WriteLine("Selecione a opcao do menu: ");
//     opcao = Console.ReadLine();
//     switch(opcao){
//         case "Adicionar":
//                 string nomeDoCarro = Console.ReadLine();
//                 adicionarCarroNoArray(nomeDoCarro);
//         break;
//         default:
//         Console.WriteLine("opcao invalida!");
//         break;
//     }
// }

// void adicionarCarroNoArray( string nomeDoCarro) {

//     for(int i = 0; i < carros.Length-1; i++){

//         if(carros[i] == ""){

//             carros[i] = nomeDoCarro;
//             break;
//         }
//     }
// }


// string opcao = "";
// var carros = new string[1];


// while (opcao != "sair"){
//     Console.WriteLine("Selecione a opcao do menu: ");
//     opcao = Console.ReadLine();
//     switch(opcao){
//         case "Adicionar":
//                 string nomeDoCarro = Console.ReadLine();
//                 adicionarCarroNoArray(nomeDoCarro);
//         break;
//         default:
//         Console.WriteLine("opcao invalida!");
//         break;
//     }
// }

// void adicionarCarroNoArray( string nomeDoCarro) {

//     for(int i = 0; i < carros.Length-1; i++){

//         if(carros[i] == ""){

//             carros[i] = nomeDoCarro;
//             break;
//         }
//     }
// }



void numerosComplexos()
{

//var numeros = new List<int>(){1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};
//var cabecario = "Retorno Valido";

// var listaPares = numeros.Where(numero => numero % 2 ==0)
//                         .Select(numero => numero*numero)
//                         .OrderBy( numero => numeros).ToList();

var numerosI = new List<int>(){1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};

var listasParesI = numerosI
.Where(i => i % 3 ==0)
.OrderByDescending(i => i)
.GroupBy(i => i)
.Select( group => new
{
     i = group.Key   
}).ToList();

foreach (var item in listasParesI)
{   
    Console.WriteLine("********************");
    Console.WriteLine($"VALORES: {item}");
    Console.WriteLine("********************");
}
}
numerosComplexos();
