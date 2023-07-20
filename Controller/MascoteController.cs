using PokéGotchi.Models;
using static PokéGotchi.View.MascoteView;

namespace PokéGotchi.Controller
{
    internal class MascoteController
    {

        public static void MenuPrincipal(List<MascoteModel> mascotes)
        {

            int oP;
            MascoteModel? MascoteAdotado = new();

            Console.Clear(); ExibeLogo(); ExibeMenuInicial();

            do
            {

                try { oP = int.Parse(Console.ReadLine() ?? "0"); } catch { oP = -1; };

                switch (oP)
                {
                    case (int)MenuOpc.ADOTAR_MASCOTE:
                        MascoteAdotado = AdotarMascote(mascotes);
                        Console.Clear(); ExibeLogo(); ExibeMenuInicial();
                        break;

                    case (int)MenuOpc.VER_MASCOTE_ADOTADO:
                        
                        if (MascoteAdotado.Nome != null)
                        {
                            VerMascote(MascoteAdotado);
                            Console.Clear(); ExibeLogo(); ExibeMenuInicial();
                        }
                        else
                        {
                            SemMascote();
                        }
                       
                        break;

                    case (int)MenuOpc.SAIR:
                        break;

                    default:
                        ErroEncontrarOpcao();
                        break;
                }

            } while (oP != (int)MenuOpc.SAIR);

        }

        public static MascoteModel? AdotarMascote(List<MascoteModel> mascotes)
        {

            int escolhaMascote, oP;
            MascoteModel MascoteEscolhido, MascoteAdotado = new();
            
            Console.Clear();
            ExibeMenuAdocao();

            foreach (MascoteModel mascote in mascotes)
            {
                mascote.ExibirMascote();
            }

            do
            {
                try { escolhaMascote = int.Parse(Console.ReadLine() ?? "0"); } catch { escolhaMascote = -1; }
                MascoteEscolhido = ListarMascotePorId(mascotes, escolhaMascote);

                if (MascoteEscolhido == null)
                {
                    ErroEncontrarOpcao();
                }

            } while (MascoteEscolhido == null);

            ExibeManuAdocaoOPC(MascoteEscolhido);

            do
            {

                try { oP = int.Parse(Console.ReadLine() ?? "0"); } catch { oP = -1; };

                switch (oP)
                {
                    case (int)MenuAdocao.SABER_MAIS:
                        MascoteEscolhido.ExibirDetalhesMascote();
                        ExibeManuAdocaoOPC(MascoteEscolhido);
                        break;

                    case (int)MenuAdocao.ADOTAR:
                        MascoteAdotado = MascoteEscolhido;
                        ExibeAdocao(MascoteEscolhido);
                        Console.ReadLine();
                        break;

                    case (int)MenuAdocao.VOLTAR:
                        break;

                    default:
                        ErroEncontrarOpcao();
                        break;
                }

            } while (oP != (int)MenuAdocao.VOLTAR && oP != (int)MenuAdocao.ADOTAR);

            return MascoteAdotado;
        }

        public static void VerMascote(MascoteModel mascote)
        {
            int oP;

            ExibeSeusMascotesOPC(mascote);

            do
            {

                try { oP = int.Parse(Console.ReadLine() ?? "0"); } catch { oP = -1; };

                switch (oP)
                {
                    case (int)MenuMascote.VER_STATUS:
                        break;

                    case (int)MenuMascote.BRINCAR:
                        break;

                    case (int)MenuMascote.ALIMENTAR:
                        break;

                    case (int)MenuMascote.VOLTAR:
                        break;

                    default:
                        ErroEncontrarOpcao();
                        break;
                }

            } while (oP != (int)MenuMascote.VOLTAR);

        }
        public static MascoteModel ListarMascotePorId(List<MascoteModel> mascotes, int id)
        {
            MascoteModel mascote = mascotes.Find(p => p.id == id)!;
            return mascote;
        }
    }
}
