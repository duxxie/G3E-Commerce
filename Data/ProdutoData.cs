using G3ECommerce.Models;
namespace G3ECommerce.Data
{
    public static class ProdutoData
    {
        public static List<Produto> produtos = new()
        {
            new Produto( "Smartphone Orion X", "Tela 6.5\" OLED, 128 GB, 5G, câmera 50 MP", 2499.90m, 35, "Smartphones"),
            new Produto( "Notebook Vega 14", "Intel i5, 16 GB RAM, SSD 512 GB, 14\" FHD", 4299.00m, 18, "Notebooks"),
            new Produto("Fone Bluetooth Nebula Pro", "TWS, cancelamento de ruído ativo, até 30h", 499.90m, 60, "Áudio"),
            new Produto( "Monitor 27\" Altair IPS", "27\" 144 Hz, 1 ms, IPS, HDR10", 1599.00m, 22, "Monitores"),
            new Produto( "Mouse Gamer Quasar", "12.000 DPI, RGB, 7 botões programáveis", 149.90m, 80, "Periféricos"),
            new Produto(  "Teclado Mecânico Aurora",  "Switches vermelho, ABNT2, RGB", 329.00m, 40, "Periféricos"),
            new Produto(  "SSD NVMe 1 TB Pulsar",  "Leitura 3500 MB/s, escrita 3000 MB/s", 449.00m, 50, "Armazenamento"),
            new Produto( "HD Externo 2 TB Comet", "USB 3.2, portátil, 2.5\"", 389.90m, 33, "Armazenamento"),
            new Produto(  "Smartwatch Helix S", "GPS, SpO2, 5 ATM, bateria 10 dias", 699.00m, 27,  "Wearables"),
            new Produto( "Tablet Lyra 10", "10.4\" FHD, 6 GB RAM, 128 GB", 1399.00m, 19, "Tablets"),
            new Produto("Caixa de Som Pulse 30W", "Bluetooth 5.3, IPX7, estéreo", 299.90m, 55, "Áudio"),
            new Produto("Roteador Wi-Fi 6 Nova AX1800", "Dual band, OFDMA, MU-MIMO", 349.00m, 32,  "Redes"),
            new Produto("Câmera de Ação Drift 4K", "4K60, estabilização, 2 baterias", 999.00m, 14, "Câmeras"),
            new Produto("Webcam 1080p Stellar", "Full HD, microfone estéreo, clip universal", 189.90m, 48, "Acessórios de Vídeo"),
            new Produto("Carregador GaN 65W Fusion", "2x USB-C + 1x USB-A, PD/QC", 19.00m, 70, "Energia & Carregadores"),
            new Produto("Cabo USB-C 100W Titan 1.8m", "PD 100W, dados 10 Gbps", 59.90m, 120, "Cabos & Adaptadores"),
            new Produto("Power Bank 20.000 mAh Flux", "USB-C PD 30W, display LED",  239.00m, 45, "Energia & Carregadores"),
            new Produto("Headset USB Orion Call", "Microfone com redução de ruído, leve", 169.90m, 36, "Áudio")
        };

        public static List<Produto> GetProdutos()
        {
            return produtos;
        }

        public static Produto? GetProdutoPorId(string id)
        {
            return produtos.FirstOrDefault(p => p.Id == id);
        }

        public static void SetProdutos(Produto produto)
        {
            produtos.Add(produto);
        }

        public static void RemoverProduto(Produto produto)
        {
            produtos.Remove(produto);
        }
    }
}