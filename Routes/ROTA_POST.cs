using G3ECommerce.Data;
using G3ECommerce.Models;
namespace G3ECommerce.Routes
{
    public static class ROTA_POST
    {
        public static void MapPostRoutes(this WebApplication app)
        {
            app.MapPost("/api/produtos", (Produto produto) =>
            {
                ProdutoData.SetProdutos(produto);
                return Results.Created($"/api/produtos/{produto.Id}", produto);
            });
        }
    }
}