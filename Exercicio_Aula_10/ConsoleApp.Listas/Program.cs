

#region Listas

using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using ConsoleApp.Listas;

List<Livro> biblioteca = new List<Livro>
{
new Livro { Titulo = "A História do Amanhã", Autor = "Yuval Noah Harari", NumeroDePaginas = 500, 
Categoria = "História" },
new Livro { Titulo = "Sapiens", Autor = "Yuval Noah Harari", NumeroDePaginas = 450, Categoria = 
"Antropologia" },
new Livro { Titulo = "1984", Autor = "George Orwell", NumeroDePaginas = 328, Categoria = "Ficção" },
new Livro { Titulo = "O Sol é Para Todos", Autor = "Harper Lee", NumeroDePaginas = 384, Categoria = 
"Ficção" },
new Livro { Titulo = "A Revolução dos Bichos", Autor = "George Orwell", NumeroDePaginas = 112, 
Categoria = "Ficção" },
new Livro { Titulo = "Cem Anos de Solidão", Autor = "Gabriel García Márquez", NumeroDePaginas = 
417, Categoria = "Ficção" },
new Livro { Titulo = "Os Miseráveis", Autor = "Victor Hugo", NumeroDePaginas = 1463, Categoria = 
"Ficção Histórica" },
new Livro { Titulo = "Crime e Castigo", Autor = "Fyodor Dostoevsky", NumeroDePaginas = 671, 
Categoria = "Ficção" },
new Livro { Titulo = "Breves Respostas para Grandes Questões", Autor = "Stephen Hawking", 
NumeroDePaginas = 256, Categoria = "Ciência" },
new Livro { Titulo = "Uma Breve História do Tempo", Autor = "Stephen Hawking", NumeroDePaginas = 
212, Categoria = "Ciência" },
new Livro { Titulo = "Os Elementos da Experiência do Usuário", Autor = "Jesse James Garrett", 
NumeroDePaginas = 208, Categoria = "Design" },
new Livro { Titulo = "Design de Interação", Autor = "Jenny Preece", NumeroDePaginas = 809, Categoria
= "Design" },
new Livro { Titulo = "O Poder do Hábito", Autor = "Charles Duhigg", NumeroDePaginas = 400, 
Categoria = "Autoajuda" },
new Livro { Titulo = "Como Fazer Amigos e Influenciar Pessoas", Autor = "Dale Carnegie", 
NumeroDePaginas = 288, Categoria = "Autoajuda" },
new Livro { Titulo = "Subliminar", Autor = "Leonard Mlodinow", NumeroDePaginas = 304, Categoria = 
"Psicologia" },
new Livro { Titulo = "Freakonomics", Autor = "Steven D. Levitt", NumeroDePaginas = 336, Categoria = 
"Economia" },
new Livro { Titulo = "Outliers", Autor = "Malcolm Gladwell", NumeroDePaginas = 336, Categoria = 
"Psicologia" },
new Livro { Titulo = "Don't Make Me Think", Autor = "Steve Krug", NumeroDePaginas = 200, Categoria 
= "Tecnologia" },
new Livro { Titulo = "O Andar do Bêbado", Autor = "Leonard Mlodinow", NumeroDePaginas = 272, 
Categoria = "Ciência" },
new Livro { Titulo = "O Gene Egoísta", Autor = "Richard Dawkins", NumeroDePaginas = 360, Categoria 
= "Biologia" },
new Livro { Titulo = "O Mundo Assombrado pelos Demônios", Autor = "Carl Sagan", NumeroDePaginas 
= 480, Categoria = "Ciência" }
};

//Encadeamentos LINQ

//Listar todos os livros por categoria:
    //Os livros devem ser ordenados por título dentro de cada categoria

var livrosPorCategoria = biblioteca
.GroupBy(x => x.Titulo)
.Select( groupo => new 
{ 
    Titulo = groupo.Key,
    Categoria = groupo.OrderBy( x => x.Categoria ).ToList()

}).ToList();

//Livros com mais de 400 paginas
var livrosLongos = biblioteca
.GroupBy(x => x.Titulo)
.Select( groupo => new {
    Titulo = groupo.Key,
    NumeroDePaginas = groupo.Where(x => x.NumeroDePaginas >= 400 ).ToList()

}).ToList();

Console.WriteLine();

//Quantidade de livros por Autor

var livrosPorAutor = biblioteca
.GroupBy( a => a.Autor)
.Select( groupo => new{
    Autor = groupo.Key,
    Quantidade = groupo.Count()
}).ToList();

Console.WriteLine();
#endregion Listas