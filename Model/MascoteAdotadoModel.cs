namespace PokéGotchi.Model
{
    internal class MascoteAdotadoModel
    {
        public int id { get; set; }

        public string Nome { get; set; }

        public int Altura { get; set; }

        public int Peso { get; set; }
        public List<String> Habilidades { get; set; }

        public List<String> Tipos { get; set; }

        public int Alegria { get; set; }

        public int Fome { get; private set; }

        // Metodo Construtor
        public MascoteAdotadoModel() 
        {
            Alegria = 5;
            Fome = 5;
        }

        public void ExibirMascote()
        {
            Console.WriteLine($"nº{id} - {Nome}");
        }

        public void ExibirDetalhesMascote()
        {
            Console.WriteLine("----------------------------- DETALHES -------------------------------");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Altura: {Altura}");
            Console.WriteLine($"Peso: {Peso}");
            Console.WriteLine($"{Nome} esta {((Alegria > 5) ? "Feliz" : "Triste")}");
            Console.WriteLine($"{Nome} esta {((Fome > 5) ? "Satisfeito" : "Faminto")}");
            Console.WriteLine($"Habilidade(s): ");
            foreach (var hNome in Habilidades)
            {
                Console.WriteLine(hNome);
            }
            Console.WriteLine($"Tipo(s): ");
            foreach (var tNome in Tipos)
            {
                Console.WriteLine(tNome);
            }
        }

        public void Alimentar() 
        {
            if (Fome < 10)
            {
                Console.WriteLine($"Seu {Nome} esta comendo . . .");
                Fome++;
                Alegria--;
            }
            else 
            {
                Console.WriteLine($"Seu {Nome} esta satisfeito e triste");
            }
        }

        public void Brincar()
        {
            if (Alegria < 10)
            {
                Console.WriteLine($"Seu {Nome} esta Brincando . . .");
                Alegria++;
                Fome--;
            }
            else
            {
                Console.WriteLine($"Seu {Nome} esta cansado e com fome");
            }
        }
    }
}
