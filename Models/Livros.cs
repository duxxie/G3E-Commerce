namespace Biblioteca.Models
{
    public class Livros
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }

        public Livros(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
        }
        
        public Livros() { }
    }
}