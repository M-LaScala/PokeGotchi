using PokéGotchi.Model;
using PokéGotchi.Utilitarios;

namespace PokéGotchi.View
{
    internal class PokeGotchiView
    {
       
        public enum MenuMascote 
        {
            VER_STATUS,
            BRINCAR,
            ALIMENTAR,
            VOLTAR
        }

        public static void ExibeLogo()
        {
            Console.WriteLine("\r\n  _______                                _       _     _ \r\n |__   __|                              | |     | |   (_)\r\n    | | __ _ _ __ ___   __ _  __ _  ___ | |_ ___| |__  _ \r\n    | |/ _` | '_ ` _ \\ / _` |/ _` |/ _ \\| __/ __| '_ \\| |\r\n    | | (_| | | | | | | (_| | (_| | (_) | || (__| | | | |\r\n    |_|\\__,_|_| |_| |_|\\__,_|\\__, |\\___/ \\__\\___|_| |_|_|\r\n                              __/ |                      \r\n                             |___/                       \r\n");
            DigitarNoCMD.EscreverLetraPorLetra("\nCoded by Matheus La Scala",45);
        }

        public static void ExibirMenus(Dictionary<int,string> LinhasMenu, string NomeMenu)
        {
            DigitarNoCMD.EscreverLetraPorLetra($"-------------------------------- {NomeMenu} --------------------------------",45);
            foreach(KeyValuePair<int, string> menu in LinhasMenu)
            {
                DigitarNoCMD.EscreverLetraPorLetra($"{menu.Key} - {menu.Value}",45);
            }
        }
        public static void ExibeMenuAdocao()
        {
            Console.WriteLine("------------------------- ADOTAR UM MASCOTE --------------------------");
            Console.WriteLine("Escolha uma especie: ");
        }
        public static void ExibeManuAdocaoOPC(Mascote MascoteEscolhido)
        {
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine($"{(int)MenuAdocao.SABER_MAIS} - Saber mais sobre o(a) {MascoteEscolhido.Nome}");
            Console.WriteLine($"{(int)MenuAdocao.ADOTAR} - Adotar {MascoteEscolhido.Nome}");
            Console.WriteLine($"{(int)MenuAdocao.VOLTAR} - Voltar");
        }
        public static void ExibeAdocao(Mascote MascoteEscolhido)
        {
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine($"Mascote {MascoteEscolhido.Nome} adotado com sucesso!\n\n\n\n");
            Console.WriteLine("Pressione enter para continuar.");
        }

        public static void ExibeSeusMascotesOPC(MascoteAdotado MascoteEscolhido)
        {
            Console.WriteLine("---------------------------- VER MASCOTE -----------------------------");
            Console.WriteLine($"Agora você vai poder brincar com seu novo amigo! {MascoteEscolhido.Nome}");
            Console.WriteLine($"{(int)MenuMascote.VER_STATUS} - Saber como {MascoteEscolhido.Nome} esta");
            Console.WriteLine($"{(int)MenuMascote.BRINCAR} - Brincar com {MascoteEscolhido.Nome}");
            Console.WriteLine($"{(int)MenuMascote.ALIMENTAR} - Alimentar {MascoteEscolhido.Nome}");
            Console.WriteLine($"{(int)MenuMascote.VOLTAR} - Voltar");
        }

        public static void SemMascote()
        {
            Console.WriteLine("---------------------------- VER MASCOTE -----------------------------");
            Console.WriteLine("Você ainda não adotou um mascote!");
            Console.WriteLine("Por favor, gentileza entrar com uma nova opcao.");
        }

        public static void ErroEncontrarOpcao()
        {
            DigitarNoCMD.EscreverLetraPorLetra("Opcao não encontrado. Por favor, digite novamente!",45);
        }

        public static void ExibirNovaOpc()
        {
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("Por favor, gentileza entrar com uma nova opcao.");
        }

        public static void ExibirBuscaMascote() 
        {
            DigitarNoCMD.EscreverLetraPorLetra("Por favor, digite o nome do mascote que deseja procurar:", 45);
        }
    }
}
