using System.Reflection.Metadata.Ecma335;
using G3ECommerce.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var produto = new List<Produto>
{
    new Produto ( 1, "Clean Code"),
    new Produto ( 2, "Domain-Driven Design")
};

app.MapGet("/produto", () => produto);

//GET{Id}
//POST
//DELETE{Id}
app.Run();