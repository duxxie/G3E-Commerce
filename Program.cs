using System.Reflection.Metadata.Ecma335;
using Biblioteca.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<Livros> livros = new List<Livros>();

void AdicionarLivro(string titulo, string autor)
{
    var novoId = livros.Any() ? livros.Max(l => l.Id) + 1 : 1;
    livros.Add(new Livros(titulo, autor) { Id = novoId });
}

AdicionarLivro("Das Kapital", "Karl Marx");
AdicionarLivro("Left and Right", "Noberto Bobbio");
AdicionarLivro("State, Society and Government"  , "Noberto Bobbio");
AdicionarLivro("1984", "George Orwell");

app.MapGet("/", () => livros);
app.Run();