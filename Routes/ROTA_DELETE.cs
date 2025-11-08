using G3ECommerce.Models;
namespace G3ECommerce.Routes
{
    public static class ROTA_DELETE
    {
        public static void MapDeleteRoutes(this WebApplication app)
        {
            // Rota Delete: /api/produtos/id 
            app.MapDelete("/api/produtos/{id}", (int id) =>
            {
                var prodItem = Produto.produtos.FirstOrDefault(r => r.Id == id);
                if (prodItem is null)
                    return Results.NotFound("Referência não encontrada.");

                Produto.produtos.Remove(prodItem);
                return Results.NoContent();
            });
        }
    }
}