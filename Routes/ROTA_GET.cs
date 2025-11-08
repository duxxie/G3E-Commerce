using G3ECommerce.Models;
namespace G3ECommerce.Routes
{
    public static class ROTA_GET
    {
        public static void MapGetRoutes(this WebApplication app)
        {
            // Rota padrão: /
            app.MapGet("/", () => "Api de Vendas e Pedidos funcionando!!!\n ROTA_GET FUNCIONANDO!");
            // Rota get: /api/produtos
            app.MapGet("/api/produtos", () => Produto.produtos);
            // Rota get id: /api/produtos/id
            app.MapGet("/api/produtos/{id}", (int id) =>
            {
                var produto = Produto.produtos.FirstOrDefault(r => r.Id == id);
                return produto != null ? Results.Ok(produto) : Results.NotFound("Produto Inexistente.");
            });
        }
    }
}