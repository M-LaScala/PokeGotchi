using PokéGotchi.Model;
using PokéGotchi.Utilitarios;
using static PokéGotchi.View.PokeGotchiView;

namespace PokéGotchi.Menu
{
    internal class MenuPrincipal
    {
        private readonly Dictionary<int, string> MenuOpc = new()
        {
                {0, "Pesquisar Mascote" },
                {1, "Adotar mascote" },
                {2, "Brincar com seu mascote" },
                {3, "Sair" }
        };

        public void ExibirMenu(List<Mascote> mascotes)
        {

            int opc;

            Console.Clear(); ExibeLogo(); ExibirMenus(MenuOpc, "Menu");

            try { opc = int.Parse(Console.ReadLine() ?? "0"); } catch { opc = -1; };

            // Valida opção
            if (MenuOpc.ContainsKey(opc)!)
            {
                switch (opc)
                {
                    case 0:
                        ExibirBuscaMascote();
                        string nomeMascote = Console.ReadLine() ?? "null";
                        ComunicacaoAPI.BuscarMascote(mascotes, nomeMascote);
                        break;
                    case 1:
                        MenuAdocao.ExibirMenu(mascotes);
                        break;
                    case 2:
                        MenuInteracao.ExibirMenu(mascoteAdotado);
                        break;
                    case 3:
                        return;
                    default:
                        break;
                }
            }
            else
            {
                ErroEncontrarOpcao();
            }

        }

    }
}
