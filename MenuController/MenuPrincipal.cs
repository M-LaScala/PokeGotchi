using PokéGotchi.Model;
using PokéGotchi.Utilitarios;
using static PokéGotchi.View.PokeGotchiView;

namespace PokéGotchi.Menu
{
    internal class MenuPrincipal
    {
        private static readonly Dictionary<int, string> MenuOpc = new()
        {
                {0, "Pesquisar Mascote" },
                {1, "Adotar mascote" },
                {2, "Brincar com seu mascote" },
                {3, "Sair" }
        };

        public void ExibirMenu(ref List<Mascote> mascotes)
        {

            int opc;
            MascoteAdotado mascoteAdotado = new();

            Console.Clear(); ExibeLogo(); ExibirMenus(MenuOpc, "Menu principal");

            do
            {
                try { opc = int.Parse(Console.ReadLine() ?? "0"); } catch { opc = -1; };

                // Valida opção
                if (MenuOpc.ContainsKey(opc)!)
                {
                    switch (opc)
                    {
                        case 0:
                            PesquisarMascote(ref mascotes);
                            break;
                        case 1:
                            MenuAdocao.ExibirMenu(ref mascotes, ref mascoteAdotado);
                            break;
                        case 2:
                            MenuInteracao.ExibirMenu(ref mascoteAdotado);
                            break;
                        case 3:
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    ErroEncontrarOpcao();
                }

            } while (opc != 3);
        }

        public static void PesquisarMascote(ref List<Mascote> mascotes)
        {
            ExibirBuscaMascote();
            string nomeMascote = Console.ReadLine() ?? "null";
            if (ComunicacaoAPI.BuscarMascote(mascotes, nomeMascote))
            {
                ExibirMascoteEncontrado();
            }
            else
            {
                ExibirMascoteNaoEncontrado();
            }
            Thread.Sleep(2000);
        }

    }
}
