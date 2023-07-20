using PokéGotchi.Models;

namespace PokéGotchi.View
{
    internal class MascoteView
    {
        public enum MenuOpc
        {
            ADOTAR_MASCOTE,
            VER_MASCOTE_ADOTADO,
            SAIR
        }
        public enum MenuAdocao
        {
            SABER_MAIS,
            ADOTAR,
            VOLTAR
        }
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
            Console.WriteLine("\nCoded by Matheus La Scala");
        }

        public static void ExibeMenuInicial()
        {
            Console.WriteLine("-------------------------------- MENU --------------------------------");
            Console.WriteLine($"{(int)MenuOpc.ADOTAR_MASCOTE} - Adotar um mascote virtual");
            Console.WriteLine($"{(int)MenuOpc.VER_MASCOTE_ADOTADO} - Ve seu mascote");
            Console.WriteLine($"{(int)MenuOpc.SAIR} - Sair");
        }
        public static void ExibeMenuAdocao()
        {
            Console.WriteLine("------------------------- ADOTAR UM MASCOTE --------------------------");
            Console.WriteLine("Escolha uma especie: ");
        }
        public static void ExibeManuAdocaoOPC(MascoteModel MascoteEscolhido)
        {
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine($"{(int)MenuAdocao.SABER_MAIS} - Saber mais sobre o(a) {MascoteEscolhido.Nome}");
            Console.WriteLine($"{(int)MenuAdocao.ADOTAR} - Adotar {MascoteEscolhido.Nome}");
            Console.WriteLine($"{(int)MenuAdocao.VOLTAR} - Voltar");
        }
        public static void ExibeAdocao(MascoteModel MascoteEscolhido)
        {
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine($"Mascote {MascoteEscolhido.Nome} adotado com sucesso!\n\n\n\n");
            Console.WriteLine("Pressione enter para continuar.");
        }

        public static void ExibeSeusMascotesOPC(MascoteModel MascoteEscolhido)
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
            Console.WriteLine("Opcao não encontrado. Por favor, digite novamente!");
        }

        public static void ExibirNovaOpc()
        {
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("Por favor, gentileza entrar com uma nova opcao.");
        }
    }
}
