using PokéGotchi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PokéGotchi.View.MascoteView;

namespace PokéGotchi.Menu
{
    internal class MenuInteracao : IMenu
    {
        public void ExibirMenu(List<Mascote> mascotes)
        {
            int oP = -1;

            Console.Clear();


            do
            {
                if (oP != (int)MenuMascote.VOLTAR)
                {
                    ExibeSeusMascotesOPC(mascote);
                }

                try { oP = int.Parse(Console.ReadLine() ?? "0"); } catch { oP = -1; };

                switch (oP)
                {
                    case (int)MenuMascote.VER_STATUS:
                        mascote.ExibirDetalhesMascote();
                        break;

                    case (int)MenuMascote.BRINCAR:
                        mascote.Brincar();
                        break;

                    case (int)MenuMascote.ALIMENTAR:
                        mascote.Alimentar();
                        break;

                    case (int)MenuMascote.VOLTAR:
                        break;

                    default:
                        ErroEncontrarOpcao();
                        break;
                }

            } while (oP != (int)MenuMascote.VOLTAR);
        }
    }
}
