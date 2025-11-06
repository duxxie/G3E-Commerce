using System.Reflection.Metadata.Ecma335;
using Biblioteca.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var clientes = new List<Cliente>
{
    new Cliente ( 1,"Ana Souza"),
    new Cliente ( 2,"João Silva")
};

var livros = new List<Livro>
{
    new Livro ( 1, "Clean Code", "Robert C. Martin"),
    new Livro ( 2, "Domain-Driven Design", "Eric Evans")
};

var pedidos = new List<Pedido>
{
    new Pedido { Id = 1, ClienteId = 1, LivrosIds = new List<int>{ 1, 2 }, Data = DateTime.Now.AddDays(-2) },
    new Pedido { Id = 2, ClienteId = 2, LivrosIds = new List<int>{ 2 }, Data = DateTime.Now.AddDays(-1) }
};

app.MapGet("/", () => livros);

app.MapGet("/cliente", () => clientes);

app.MapGet("/pedidos", () =>
{
    var pedidosCompletos = pedidos.Select(p => new
    {
        p.Id,
        Cliente = clientes.FirstOrDefault(c => c.Id == p.ClienteId),
        Livros = livros.Where(l => p.LivrosIds.Contains(l.Id)).ToList(),
        p.Data
    });

    return Results.Ok(pedidosCompletos);
});
app.Run();