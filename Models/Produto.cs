namespace G3ECommerce.Models
{
    public class Produto
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public decimal Preco { get; set; }
        public int Estoque { get; set; }
        public string Categoria { get; set; } = string.Empty;

        public Produto(string nome, string descricao, decimal preco, int estoque, string categoria)
        {
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
            Estoque = estoque;
            Categoria = categoria;
        }        
    }
}