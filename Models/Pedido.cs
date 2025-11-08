namespace Biblioteca.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public List<int> ProdutoIds { get; set; } = new();
        public DateTime Data { get; set; } = DateTime.Now;
    }
}