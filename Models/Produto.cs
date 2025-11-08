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

        public static List<Produto> produtos = new List<Produto>()
        {
                new Produto(1, "Smartphone Samsung Galaxy S24"),
                new Produto(2, "Notebook Dell Inspiron 15"),
                new Produto(3, "Smart TV LG 55\" 4K"),
                new Produto(4, "Fone de Ouvido Bluetooth JBL Tune 510BT"),
                new Produto(5, "Mouse Gamer Logitech G203"),
                new Produto(6, "Teclado Mecânico Redragon Kumara"),
                new Produto(7, "Cadeira Gamer ThunderX3"),
                new Produto(8, "Monitor Acer 27\" Full HD"),
                new Produto(9, "Pendrive Sandisk 128GB"),
                new Produto(10, "HD Externo Seagate 2TB"),

                new Produto(11, "Livro: O Senhor dos Anéis - A Sociedade do Anel"),
                new Produto(12, "Livro: Dom Casmurro - Machado de Assis"),
                new Produto(13, "Livro: O Pequeno Príncipe - Antoine de Saint-Exupéry"),
                new Produto(14, "Livro: Clean Code - Robert C. Martin"),
                new Produto(15, "Livro: Design Patterns - GoF"),
                new Produto(16, "Livro: A Revolução dos Bichos - George Orwell"),
                new Produto(17, "Livro: O Hobbit - J.R.R. Tolkien"),
                new Produto(18, "Livro: O Código Da Vinci - Dan Brown"),
                new Produto(19, "Livro: It - A Coisa - Stephen King"),
                new Produto(20, "Livro: 1984 - George Orwell"),

                new Produto(21, "Camisa Polo Azul"),
                new Produto(22, "Calça Jeans Masculina"),
                new Produto(23, "Jaqueta de Couro Feminina"),
                new Produto(24, "Tênis Nike Air Max"),
                new Produto(25, "Boné Adidas Preto"),
                new Produto(26, "Relógio Casio Digital"),
                new Produto(27, "Mochila Dell Essential"),
                new Produto(28, "Óculos de Sol Ray-Ban"),
                new Produto(29, "Camisa Regata Esportiva"),
                new Produto(30, "Blusa de Moletom Cinza"),

                new Produto(31, "Caneta Esferográfica Azul Bic"),
                new Produto(32, "Caderno Universitário 200 Folhas"),
                new Produto(33, "Grampeador Pequeno"),
                new Produto(34, "Papel A4 Chamex 500 folhas"),
                new Produto(35, "Calculadora Científica Casio"),
                new Produto(36, "Agenda 2025 Diária"),
                new Produto(37, "Apontador com Depósito"),
                new Produto(38, "Estojo Escolar Preto"),
                new Produto(39, "Post-it Amarelo 76x76mm"),
                new Produto(40, "Régua 30cm Transparente"),

                new Produto(41, "Chocolate Milka 100g"),
                new Produto(42, "Pacote de Café 500g"),
                new Produto(43, "Caixa de Leite Integral 1L"),
                new Produto(44, "Macarrão Espaguete 500g"),
                new Produto(45, "Arroz Branco Tipo 1 5kg"),
                new Produto(46, "Feijão Carioca 1kg"),
                new Produto(47, "Biscoito Recheado Oreo"),
                new Produto(48, "Refrigerante Coca-Cola 2L"),
                new Produto(49, "Água Mineral 1,5L"),
                new Produto(50, "Molho de Tomate Tradicional 340g")
        };
    }
}