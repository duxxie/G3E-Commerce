using G3ECommerce.Data;
using G3ECommerce.Models;
namespace G3ECommerce.Routes
{
    public static class ROTA_DELETE
    {
        public static void MapDeleteRoutes(this WebApplication app)
        {
            app.MapDelete("/api/produtos/{id}", (string id) =>
            {
                var produto = ProdutoData.GetProdutoPorId(id);

                if (produto is null)
                    return Results.NotFound("Produto não encontrado");

                ProdutoData.RemoverProduto(produto);
                return Results.NoContent();
            });
        }
    }
}