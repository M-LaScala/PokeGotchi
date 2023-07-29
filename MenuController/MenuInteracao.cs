using PokéGotchi.Model;
using static PokéGotchi.View.PokeGotchiView;

namespace PokéGotchi.Menu
{
    internal class MenuInteracao
    {

        private static readonly Dictionary<int, string> MenuOpc = new()
        {
                {0, "Ver status" },
                {1, "Brincar" },
                {2, "Alimentar" },
                {3, "Voltar" }
        };

        public static void ExibirMenu(ref MascoteAdotado mascote)
        {
            int oP = -1;

            Console.Clear();

            do
            {
                if (oP != 3)
                {
                    ExibirMenus(MenuOpc,"Menu interecao");
                }

                try { oP = int.Parse(Console.ReadLine() ?? "0"); } catch { oP = -1; };

                switch (oP)
                {
                    case 0:
                        mascote.ExibirDetalhesMascote();
                        break;

                    case 1:
                        mascote.Brincar();
                        break;

                    case 2:
                        mascote.Alimentar();
                        break;

                    case 3:
                        break;

                    default:
                        ExibirErroEncontrarOpcao();
                        break;
                }

            } while (oP != 3);
        }
    }
}
