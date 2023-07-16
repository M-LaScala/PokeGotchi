using PokéGotchi.Models;
using static PokéGotchi.View.MascoteView;

namespace PokéGotchi.Controller
{
    internal class MascoteController
    {

        public static void MenuPrincipal(List<MascoteModel> mascotes)
        {

            int oP;

            do
            {
                //Console.Clear();
                ExibeLogo();
                ExibeMenuInicial();

                oP = int.Parse(Console.ReadLine() ?? "0");

                switch (oP)
                {
                    case (int)MenuOpc.ADOTAR_MASCOTE:
                        AdotarMascote(mascotes);
                        break;

                    case (int)MenuOpc.VER_MASCOTES_ADOTADOS:
                        VerMascote(mascotes);
                        break;

                    default:
                        break;
                }

            } while (oP != (int)MenuOpc.SAIR);

        }

        public static void AdotarMascote(List<MascoteModel> mascotes)
        {

            int escolhaMascote, oP;
            MascoteModel MascoteEscolhido = new();

            ExibeMenuAdocao();

            foreach (MascoteModel mascote in mascotes)
            {
                mascote.ExibirMascote();
            }

            escolhaMascote = int.Parse(Console.ReadLine() ?? "0");
            MascoteEscolhido = ListarMascotePorId(mascotes, escolhaMascote);

            do
            {
                ExibeManuAdocaoOPC(MascoteEscolhido);

                oP = int.Parse(Console.ReadLine() ?? "0");

                switch (oP)
                {
                    case (int)MenuAdocao.SABER_MAIS:
                        MascoteEscolhido.ExibirDetalhesMascote();
                        break;

                    case (int)MenuAdocao.ADOTAR:
                        ExibeAdocao(MascoteEscolhido);
                        break;

                    default:
                        break;
                }

            } while (oP != (int)MenuAdocao.VOLTAR && oP != (int)MenuAdocao.ADOTAR);


        }

        public static void VerMascote(List<MascoteModel> mascotes)
        {
            ExibeSeusMascotes();
        }

        public static MascoteModel ListarMascotePorId(List<MascoteModel> mascotes, int id)
        {
            MascoteModel mascote = mascotes.Find(p => p.id == id)!;
            return mascote;
        }

    }
}
