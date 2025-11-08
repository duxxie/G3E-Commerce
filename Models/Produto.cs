namespace G3ECommerce.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }

        public Produto(int id, string titulo)
        {
            Id = id;
            Titulo = titulo;
        }        
    }
}