using G3ECommerce.Models;
namespace G3ECommerce.Data
{
    public static class ProdutoData
    {
        public static List<Produto> produtos { get; set; } = new()
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
            new Produto("Headset USB Orion Call", "Microfone com redução de ruído, leve", 169.90m, 36, "Áudio"),
            new Produto("Soundbar 120W Nova Cinema", "2.1 canais, subwoofer, HDMI ARC", 899.00m, 12, "Áudio"),
            new Produto("Placa de Vídeo Comet GTX 1660S", "6 GB GDDR6, 1408 CUDA", 1499.00m, 8, "Placas de Vídeo"),
            new Produto("Leitor de Cartões MultiX", "USB-C/USB-A, SD e microSD UHS-II", 79.90m, 90, "Acessórios"),
            new Produto("Hub USB-C 6-em-1 Atlas", "HDMI 4K, 3x USB, PD, SD", 259.00m, 28, "Acessórios"),
            new Produto("Impressora TankJet 310", "Tanque de tinta, Wi-Fi, duplex manual", 849.00m, 11, "Impressoras"),
            new Produto("Kindle-like E-Reader Lumi 7", "Tela e-ink 7\", luz quente, 16 GB", 699.00m, 17, "Leitores Digitais"),
            new Produto("Câmera IP Dome Guard", "1080p, visão noturna, detecção de movimento", 229.00m, 40, "Segurança"),
            new Produto("Microfone Condensador Stream", "USB, cardioide, tripé incluso", 349.00m, 24, "Áudio"),
            new Produto("Switch Gigabit 8 Portas Core", "8x RJ45, fanless, metal", 199.00m, 26, "Redes"),
            new Produto("Placa-Mãe Aegis B550M", "AM4, mATX, 2x M.2, DDR4", 799.00m, 9, "Placas-mãe"),
            new Produto("TV 50\" 4K Andromeda", "VA 60 Hz, HDR10, Smart TV", 2199.00m, 13, "TVs"),
            new Produto("Ventoinha ARGB 120mm Boreal", "120 mm, PWM, kit com 3", 159.00m, 52, "Resfriamento & Fans"),
            new Produto("Console NeoPlay S", "Quad-core, 512 GB, controle sem fio", 2499.00m, 15, "Consoles"),
            new Produto("Drone SkyView 4K", "Câmera 4K, 3 eixos, 35 min voo", 2799.90m, 10, "Drones" ),
            new Produto("Câmera Mirrorless Aster M10", "24 MP, vídeo 4K30, lente 15-45mm", 3499.00m, 7, "Câmeras"),
            new Produto("Lâmpada Smart Lumos E27", "RGB, Wi-Fi, compatível com assistentes", 69.90m, 120, "Casa Inteligente"),
            new Produto("Tomada Smart Plug VoltX", "Monitoramento de energia, Wi-Fi", 79.90m, 75 ,"Casa Inteligente"),
            new Produto("Câmera Veicular DriveCam", "1080p, ângulo 170°, modo estacionamento", 229.90m, 40, "Acessórios Automotivos"),
            new Produto("Leitor Kindle-like Lumi 8 Pro", "Tela e-ink 8\" com warm light, 32 GB", 899.00m, 14, "Leitores Digitais"),
            new Produto("VR Headset Orion VR2", "Tela 120 Hz, inside-out tracking", 1999.00m, 9, "VR/AR"),
            new Produto("NAS 2-Bays CloudBox 2","2x bays 3.5\", 2.5GbE, apps de backup", 1699.00m, 12, "Armazenamento em Rede"),
            new Produto("Nobreak 1000VA GuardPro", "8 tomadas, estabilização, AVR", 749.00m, 18, "Energia & Carregadores"),
            new Produto("Projetor Home CineBeam 1080", "1080p, 3500 lumens, HDMI/USB", 1999.00m, 11, "Projetores"),
            new Produto("Caixa de Som Smart EchoBeat", "Assistente de voz, Wi-Fi/Bluetooth", 449.00m, 33, "Áudio"),
            new Produto("Placa de Vídeo Aegis RTX 3060", "12 GB GDDR6, ray tracing", 2199.00m, 6,  "Placas de Vídeo"),
            new Produto("Repetidor/Mesh Wi-Fi NovaMesh M1", "AX3000, roaming contínuo", 429.00m, 29, "Redes"),
            new Produto("Gimbal Mobile SteadyGo 3", "3 eixos, modos follow, 12h bateria", 599.00m, 20, "Acessórios de Vídeo"),
            new Produto("Carregador Sem Fio 15W WavePad", "Qi 15W, base antiderrapante", 129.90m, 85, "Energia & Carregadores"),
            new Produto("Barra HDMI 2.1 8K UltraLink", "Cabo 2 m, 48 Gbps, eARC", 89.90m, 150, "Cabos & Adaptadores"),
            new Produto("Headphone Studio Orion One", "Over-ear, cabo destacável, 40 mm", 379.00m, 26, "Áudio"),
            new Produto("Leitor Biométrico SecureID USB", "Impressão digital, SDK incluso", 269.00m, 22, "Acessórios"),
            new Produto("Dock USB-C Pro 11-em-1 Atlas Max", "2x HDMI 4K, 1x DP, 3x USB, RJ45, SD, PD", 589.00m, 17, "Acessórios"),
            new Produto("Smartphone Orion Z Lite", "6.1\" OLED, 128 GB, 5G, câmera 48 MP", 2199.00m, 25, "Smartphones"),
            new Produto("Notebook Vega 15 Pro", "Ryzen 7, 16 GB, SSD 1 TB, 15.6\" 120 Hz", 5999.00m, 9, "Notebooks"),
            new Produto("All-in-One Boreal 24", "Intel i5, 8 GB, SSD 512 GB, 23.8\" FHD",3799.00m, 7, "Computadores"),
            new Produto("Monitor 34\" UltraWide Helios", "3440x1440, 144 Hz, 1 ms, HDR400", 2899.00m, 11, "Monitores"),
            new Produto( "Mouse Sem Fio Aero Slim", "Bluetooth/2.4G, 1600 DPI, recarregável",119.90m, 70, "Periféricos"),
            new Produto("Teclado Low Profile Nimbus", "Switch óptico, ABNT2, RGB", 429.00m, 28, "Periféricos"),
            new Produto("Headset Gamer Vega 7.1", "Som 7.1 virtual, microfone removível", 299.90m, 34, "Áudio"),
            new Produto("SSD SATA 480 GB Core", "Leitura 550 MB/s, escrita 480 MB/s", 199.00m, 65, "Armazenamento"),
            new Produto("SSD NVMe 2 TB Comet Pro", "Leitura 7000 MB/s, escrita 6500 MB/s", 899.00m, 15, "Armazenamento"),
            new Produto("HD Interno 4 TB Atlas", "7200 RPM, 3.5\", cache 256 MB", 699.00m, 20, "Armazenamento"),
            new Produto("Roteador Wi-Fi 6E Nova AXE5400", "Tri-band, OFDMA, MU-MIMO, WPA3", 1099.00m, 13, "Redes"),
            new Produto("Adaptador USB Wi-Fi AX300", "USB-A, Wi-Fi 6, antena destacável", 139.90m, 80, "Redes"),
            new Produto("Switch Gigabit 16 Portas Rack", "16x RJ45, metal, fanless", 399.00m, 18, "Redes"),
            new Produto("Webcam 2K CrystalView", "1440p, foco automático, tampa de privacidade", 279.00m, 29, "Acessórios de Vídeo"),
            new Produto("Microfone USB PodCast X", "Cardioide, ganho e mute, shock mount", 449.00m, 22, "Áudio"),
            new Produto("Ring Light 12\" Lumina", "Temperatura ajustável, tripé 2 m", 159.90m, 55, "Acessórios de Vídeo"),
            new Produto("Gimbal Cam Pro 4", "3 eixos, follow, timelapse, 14h", 749.00m, 14, "Acessórios de Vídeo"),
            new Produto("Câmera de Ação Drift 4K Mini", "4K30, corpo compacto, prova d’água", 749.00m, 19, "Câmeras"),
            new Produto("Câmera IP Bullet Guard Pro", "2K, visão noturna colorida, PoE", 389.00m, 27, "Segurança"),
            new Produto("Smartwatch Helix Fit",  "GPS, NFC, 50 m, bateria 7 dias", 899.00m, 21, "Wearables"),
            new Produto("Soundbar 240W Nova Cinema Plus", "3.1 canais, subwoofer sem fio, DTS", 1499.00m, 8,  "Áudio"),
            new Produto("Caixa de Som 50W Pulse Max", "Bluetooth 5.3, IP67, pareamento estéreo", 449.00m, 38,  "Áudio"),
            new Produto("TV 55\" 4K Andromeda QLED", "120 Hz, HDR10+, Dolby Vision, Smart",  3499.00m, 10, "TVs"),
            new Produto( "TV 65\" 4K Andromeda MiniLED", "144 Hz, VRR, Dolby Atmos", 5299.00m, 6, "TVs"),
            new Produto("Placa-mãe Aegis B650M", "AM5, mATX, DDR5, PCIe 5.0", 1199.00m, 12, "Placas-mãe"),
            new Produto("Placa de Vídeo Orion RTX 4070", "12 GB GDDR6X, ray tracing, DLSS", 4599.00m, 5, "Placas de Vídeo"),
            new Produto("Cooler CPU Boreal Twin 240", "Water cooler 240 mm, PWM, ARGB", 499.00m, 16, "Resfriamento & Fans"),
            new Produto("Ventoinha ARGB 140mm Boreal",  "140 mm, PWM, pack com 2", 189.00m, 40, "Resfriamento & Fans"),
            new Produto("Carregador GaN 100W Fusion Pro", "2x USB-C PD + 1x USB-A QC", 329.00m, 33, "Energia & Carregadores"),
            new Produto("Power Bank 30.000 mAh Flux Max", "USB-C PD 45W, passthrough, display", 349.00m, 25, "Energia & Carregadores")
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