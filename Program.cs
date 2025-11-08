using System.Reflection.Metadata.Ecma335;
using Biblioteca.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var clientes = new List<Cliente>
{
    new Cliente ( 1,"Ana Souza"),
    new Cliente ( 2,"João Silva")
};

var produto = new List<Livro>
{
    new Livro ( 1, "Clean Code"),
    new Livro ( 2, "Domain-Driven Design")
};

var pedidos = new List<Pedido>
{
    new Pedido { Id = 1, ClienteId = 1, ProdutoIds = new List<int>{ 1, 2 }, Data = DateTime.Now.AddDays(-2) },
    new Pedido { Id = 2, ClienteId = 2, ProdutoIds = new List<int>{ 2 }, Data = DateTime.Now.AddDays(-1) }
};

app.MapGet("/produto", () => produto);


app.MapGet("/cliente", () => clientes);

app.MapGet("/pedidos", () =>
{
    var pedidosCompletos = pedidos.Select(p => new
    {
        p.Id,
        Cliente = clientes.FirstOrDefault(c => c.Id == p.ClienteId),
        Produto = produto.Where(l => p.ProdutoIds.Contains(l.Id)).ToList(),
        p.Data
    });

    return Results.Ok(pedidosCompletos);
});
app.Run();