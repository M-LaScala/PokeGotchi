using PokéGotchi.Model;
using PokéGotchi.Utilitarios;

namespace PokéGotchi.View
{
    internal class PokeGotchiView
    {

        private const int VELOCIDADE = 0;

        public static void ExibirLogo()
        {
            Console.WriteLine("\r\n  _______                                _       _     _ \r\n |__   __|                              | |     | |   (_)\r\n    | | __ _ _ __ ___   __ _  __ _  ___ | |_ ___| |__  _ \r\n    | |/ _` | '_ ` _ \\ / _` |/ _` |/ _ \\| __/ __| '_ \\| |\r\n    | | (_| | | | | | | (_| | (_| | (_) | || (__| | | | |\r\n    |_|\\__,_|_| |_| |_|\\__,_|\\__, |\\___/ \\__\\___|_| |_|_|\r\n                              __/ |                      \r\n                             |___/                       \r\n");
            DigitarNoCMD.EscreverLetraPorLetra("\nCoded by Matheus La Scala", VELOCIDADE);
        }

        public static void ExibirMenus(Dictionary<int,string> LinhasMenu, string NomeMenu)
        {   
            Console.WriteLine($"-------------------------------- {NomeMenu} --------------------------------");
            foreach(KeyValuePair<int, string> menu in LinhasMenu)
            {
                DigitarNoCMD.EscreverLetraPorLetra($"{menu.Key} - {menu.Value}", VELOCIDADE);
            }
        }
        public static void ExibirMenuAdocao()
        {
            Console.WriteLine("------------------------- ADOTAR UM MASCOTE --------------------------");
            DigitarNoCMD.EscreverLetraPorLetra("Escolha uma especie: ", VELOCIDADE);
        }
        public static void ExibirAdocao(Mascote MascoteEscolhido)
        {
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine($"Mascote {MascoteEscolhido.Nome} adotado com sucesso!\n\n\n\n");
            Console.WriteLine("Pressione enter para continuar.");
        }

        public static void ExibirSemMascote()
        {
            Console.WriteLine("---------------------------- VER MASCOTE -----------------------------");
            Console.WriteLine("Você ainda não adotou um mascote!");
        }

        public static void ExibirErroEncontrarOpcao()
        {
            Console.WriteLine("Opcao não encontrado. Por favor, digite novamente!");
        }

        public static void ExibirNovaOpc()
        {
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("Por favor, gentileza entrar com uma nova opcao.");
        }

        public static void ExibirBuscaMascote() 
        {
            Console.WriteLine("Por favor, digite o nome do mascote que deseja procurar:");
        }

        public static void ExibirMascoteEncontrado()
        {
            Console.WriteLine("O mascote foi encontrado e adicionado a lista.");
        }   
        public static void ExibirMascoteNaoEncontrado()
        {
            Console.WriteLine("Nenhum mascote foi encontrado ou mascote já exite na lista!");
        }
        public static void ExibirAguarde()
        {
            Console.WriteLine("Aguarde para voltar ao menu!");
        }
        public static void ExibirContinuarAdicionarMascote()
        {
            Console.WriteLine("Buscar outro mascote sim (1) não (0)!");
        }
    }
}
