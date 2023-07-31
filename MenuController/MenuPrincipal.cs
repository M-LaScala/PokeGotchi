using PokéGotchi.Model;
using PokéGotchi.Utilitarios;
using static PokéGotchi.View.PokeGotchiView;

namespace PokéGotchi.Menu
{
    internal class MenuPrincipal
    {
        private static readonly Dictionary<int, string> MenuOpc = new()
        {
                {0, "Pesquisar mascote" },
                {1, "Adotar mascote" },
                {2, "Brincar com seu mascote" },
                {3, "Sair" }
        };

        public void ExibirMenu(ref List<Mascote> mascotes)
        {

            int opc = -1;
            MascoteAdotado mascoteAdotado = new();

            Console.Clear(); ExibirLogo(); ExibirMenus(MenuOpc, "Menu principal");

            do
            {
                if (opc != -1)
                {
                    Console.Clear(); ExibirLogo(); ExibirMenus(MenuOpc, "Menu principal");
                }

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
                            
                            if (mascoteAdotado.Nome is not null)
                            {
                                MenuInteracao.ExibirMenu(ref mascoteAdotado);
                            }
                            else
                            {
                                ExibirSemMascote();
                                ExibirAguarde();
                                Thread.Sleep(5000);
                            }

                            break;
                        case 3:
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    ExibirErroEncontrarOpcao();
                }

            } while (opc != 3);
        }

        public static void PesquisarMascote(ref List<Mascote> mascotes)
        {
            int opc;

            do
            {
                Console.Clear();
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

                ExibirContinuarAdicionarMascote();

                try { opc = int.Parse(Console.ReadLine() ?? "0"); } catch { opc = -1; };

            } while (opc == 1);

            ExibirAguarde();
            Thread.Sleep(2000); // 3 segundos

        }

    }
}
