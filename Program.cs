using System.Reflection.Metadata.Ecma335;
using G3ECommerce.Routes;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//ROTAS GET
app.MapGetRoutes();

//POST

//DELETE{Id}

app.Run();