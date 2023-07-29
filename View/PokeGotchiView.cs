using PokéGotchi.Model;
using PokéGotchi.Utilitarios;

namespace PokéGotchi.View
{
    internal class PokeGotchiView
    {

        private const int VELOCIDADE = 0;

        public static void ExibeLogo()
        {
            Console.WriteLine("\r\n  _______                                _       _     _ \r\n |__   __|                              | |     | |   (_)\r\n    | | __ _ _ __ ___   __ _  __ _  ___ | |_ ___| |__  _ \r\n    | |/ _` | '_ ` _ \\ / _` |/ _` |/ _ \\| __/ __| '_ \\| |\r\n    | | (_| | | | | | | (_| | (_| | (_) | || (__| | | | |\r\n    |_|\\__,_|_| |_| |_|\\__,_|\\__, |\\___/ \\__\\___|_| |_|_|\r\n                              __/ |                      \r\n                             |___/                       \r\n");
            DigitarNoCMD.EscreverLetraPorLetra("\nCoded by Matheus La Scala", VELOCIDADE);
        }

        public static void ExibirMenus(Dictionary<int,string> LinhasMenu, string NomeMenu)
        {   
            DigitarNoCMD.EscreverLetraPorLetra($"-------------------------------- {NomeMenu} --------------------------------",VELOCIDADE);
            foreach(KeyValuePair<int, string> menu in LinhasMenu)
            {
                DigitarNoCMD.EscreverLetraPorLetra($"{menu.Key} - {menu.Value}", VELOCIDADE);
            }
        }
        public static void ExibeMenuAdocao()
        {
            DigitarNoCMD.EscreverLetraPorLetra("------------------------- ADOTAR UM MASCOTE --------------------------", VELOCIDADE);
            DigitarNoCMD.EscreverLetraPorLetra("Escolha uma especie: ", VELOCIDADE);
        }
        public static void ExibeAdocao(Mascote MascoteEscolhido)
        {
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine($"Mascote {MascoteEscolhido.Nome} adotado com sucesso!\n\n\n\n");
            Console.WriteLine("Pressione enter para continuar.");
        }

        public static void SemMascote()
        {
            Console.WriteLine("---------------------------- VER MASCOTE -----------------------------");
            Console.WriteLine("Você ainda não adotou um mascote!");
            Console.WriteLine("Por favor, gentileza entrar com uma nova opcao.");
        }

        public static void ErroEncontrarOpcao()
        {
            DigitarNoCMD.EscreverLetraPorLetra("Opcao não encontrado. Por favor, digite novamente!",VELOCIDADE);
        }

        public static void ExibirNovaOpc()
        {
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("Por favor, gentileza entrar com uma nova opcao.");
        }

        public static void ExibirBuscaMascote() 
        {
            DigitarNoCMD.EscreverLetraPorLetra("Por favor, digite o nome do mascote que deseja procurar:", VELOCIDADE);
        }

        public static void ExibirMascoteEncontrado()
        {
            DigitarNoCMD.EscreverLetraPorLetra("O mascote foi encontrado e adicionado a lista",VELOCIDADE);
        }
        public static void ExibirMascoteNaoEncontrado()
        {
            DigitarNoCMD.EscreverLetraPorLetra("Nenhum mascote foi encontrado", VELOCIDADE);
        }
    }
}
