using PokéGotchi.Models;
using static PokéGotchi.View.MascoteView;

namespace PokéGotchi.Controller
{
    internal class MascoteController
    {

        public static void MenuPrincipal(List<MascoteModel> mascotes)
        {

            int oP;
            MascoteModel? MascoteEscolhido = new();

            do
            {
                Console.Clear();
                ExibeLogo();
                ExibeMenuInicial();

                oP = int.Parse(Console.ReadLine() ?? "0");

                switch (oP)
                {
                    case (int)MenuOpc.ADOTAR_MASCOTE:
                        MascoteEscolhido = AdotarMascote(mascotes);
                        break;

                    case (int)MenuOpc.VER_MASCOTE_ADOTADO:
                        
                        if (MascoteEscolhido.Nome != null)
                        {
                            VerMascote(MascoteEscolhido);
                            Console.ReadLine();
                        }
                        else
                        {
                            SemMascote();
                            Console.ReadLine();
                        }
                       
                        break;

                    default:
                        break;
                }

            } while (oP != (int)MenuOpc.SAIR);

        }

        public static MascoteModel? AdotarMascote(List<MascoteModel> mascotes)
        {

            int escolhaMascote, oP;
            MascoteModel MascoteEscolhido = new();

            ExibeMenuAdocao();

            foreach (MascoteModel mascote in mascotes)
            {
                mascote.ExibirMascote();
            }

            do
            {
                escolhaMascote = int.Parse(Console.ReadLine() ?? "0");
                MascoteEscolhido = ListarMascotePorId(mascotes, escolhaMascote);

                if (MascoteEscolhido == null)
                {
                    ErroEncontrarOpcao();
                }

            } while (MascoteEscolhido == null);
            

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
                        Console.ReadLine();
                        break;

                    default:
                        ErroEncontrarOpcao();
                        break;
                }

            } while (oP != (int)MenuAdocao.VOLTAR && oP != (int)MenuAdocao.ADOTAR);

            return MascoteEscolhido;
        }

        public static void VerMascote(MascoteModel mascotes)
        {
            ExibeSeusMascotes(mascotes);
        }

        public static MascoteModel ListarMascotePorId(List<MascoteModel> mascotes, int id)
        {
            MascoteModel mascote = mascotes.Find(p => p.id == id)!;
            return mascote;
        }


    }
}
