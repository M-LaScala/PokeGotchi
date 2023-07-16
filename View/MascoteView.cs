using PokéGotchi.Models;

namespace PokéGotchi.View
{
    internal class MascoteView
    {
        public enum MenuOpc
        {
            ADOTAR_MASCOTE,
            VER_MASCOTES_ADOTADOS,
            SAIR
        }
        public enum MenuAdocao
        {
            SABER_MAIS,
            ADOTAR,
            VOLTAR
        }

        public static void ExibeLogo()
        {
            Console.WriteLine("\r\n  _______                                _       _     _ \r\n |__   __|                              | |     | |   (_)\r\n    | | __ _ _ __ ___   __ _  __ _  ___ | |_ ___| |__  _ \r\n    | |/ _` | '_ ` _ \\ / _` |/ _` |/ _ \\| __/ __| '_ \\| |\r\n    | | (_| | | | | | | (_| | (_| | (_) | || (__| | | | |\r\n    |_|\\__,_|_| |_| |_|\\__,_|\\__, |\\___/ \\__\\___|_| |_|_|\r\n                              __/ |                      \r\n                             |___/                       \r\n");
            Console.WriteLine("Coded by Matheus La Scala\n");
        }

        public static void ExibeMenuInicial()
        {
            Console.WriteLine("-------------------------------- MENU --------------------------------");
            Console.WriteLine($"{(int)MenuOpc.ADOTAR_MASCOTE} - Adotar um mascote virtual");
            Console.WriteLine($"{(int)MenuOpc.VER_MASCOTES_ADOTADOS} - Ver seus mascote(s)");
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
            Console.WriteLine($"Mascote {MascoteEscolhido.Nome} adotado com sucesso!");
        }

        public static void ExibeSeusMascotes()
        {
            Console.WriteLine("---------------------------- VER MASCOTE -----------------------------");
            Console.WriteLine("Escolha um de seu(s) mascote(s)!");
        }

    }
}
