using PokéGotchi.Models;
using System.Globalization;

namespace PokéGotchi;

internal class Menu
{

    enum MenuOpc
    {
        ADOTAR_MASCOTE,
        VER_MASCOTES_ADOTADOS,
        SAIR
    }
    enum MenuAdocao
    {
        SABER_MAIS,
        ADOTAR,
        VOLTAR
    }

    public static void ExibeMenu(List<Mascote> mascotes)
    {
        // Mensagen Tamagotchi
        Console.WriteLine("\r\n  _______                                _       _     _ \r\n |__   __|                              | |     | |   (_)\r\n    | | __ _ _ __ ___   __ _  __ _  ___ | |_ ___| |__  _ \r\n    | |/ _` | '_ ` _ \\ / _` |/ _` |/ _ \\| __/ __| '_ \\| |\r\n    | | (_| | | | | | | (_| | (_| | (_) | || (__| | | | |\r\n    |_|\\__,_|_| |_| |_|\\__,_|\\__, |\\___/ \\__\\___|_| |_|_|\r\n                              __/ |                      \r\n                             |___/                       \r\n");
        Console.WriteLine("Coded by Matheus La Scala\n");

        int oP;
        do
        {
            Console.WriteLine("-------------------------------- MENU --------------------------------");
            Console.WriteLine($"{(int)MenuOpc.ADOTAR_MASCOTE} - Adotar um mascote virtual");
            Console.WriteLine($"{(int)MenuOpc.VER_MASCOTES_ADOTADOS} - Ver seus mascote(s)");
            Console.WriteLine($"{(int)MenuOpc.SAIR} - Sair");

            oP = int.Parse(Console.ReadLine() ?? "0");

            if (oP != (int)MenuOpc.SAIR)
            {
                EscolhaDoMenu(oP, mascotes);
            }

            
        } while (oP != (int)MenuOpc.SAIR); 

    }

    public static void EscolhaDoMenu(int oP, List<Mascote> mascotes)
    {
        switch (oP)
        {
            case (int)MenuOpc.ADOTAR_MASCOTE:
                Console.WriteLine("------------------------- ADOTAR UM MASCOTE --------------------------");
                AdotarMascote(mascotes);
                break;

            case (int)MenuOpc.VER_MASCOTES_ADOTADOS:
                Console.WriteLine("---------------------------- VER MASCOTE -----------------------------");
                VerMascote(mascotes);
                break;

            default:
                break;
        }
    }

    public static void AdotarMascote(List<Mascote> mascotes)
    {
       
        int escolhaMascote, oP;
        Mascote MascoteEcolhido = new();

        Console.WriteLine("Escolha uma especie: ");
        foreach (Mascote mascote in mascotes)
        {
            mascote.ExibirMascote();
        }

        escolhaMascote = int.Parse(Console.ReadLine() ?? "0");
        MascoteEcolhido = ListarMascotePorId(mascotes, escolhaMascote);

        do
        {    
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine($"{(int)MenuAdocao.SABER_MAIS} - Saber mais sobre o(a) {MascoteEcolhido.Nome}");
            Console.WriteLine($"{(int)MenuAdocao.ADOTAR} - Adotar {MascoteEcolhido.Nome}");
            Console.WriteLine($"{(int)MenuAdocao.VOLTAR} - Voltar");

            oP = int.Parse(Console.ReadLine() ?? "0");

            switch (oP)
            {
                case (int)MenuAdocao.SABER_MAIS:
                    Console.WriteLine("----------------------------- DETALHES -------------------------------");
                    MascoteEcolhido.ExibirDetalhesMascote();
                    break;

                case (int)MenuAdocao.ADOTAR:
                    Console.WriteLine("----------------------------------------------------------------------");
                    Console.WriteLine($"Mascote {MascoteEcolhido.Nome} adotado com sucesso!");
                    break;

                default:
                    break;
            }

        } while (oP != (int)MenuAdocao.VOLTAR);


    }

    public static void VerMascote(List<Mascote> mascotes)
    {
        Console.WriteLine("Escolha um de seu(s) mascote(s)!");
    }

    public static Mascote ListarMascotePorId(List<Mascote> mascotes, int id)
    {
        Mascote mascote = mascotes.Find(p => p.id == id)!;
        return mascote;
    }

}
