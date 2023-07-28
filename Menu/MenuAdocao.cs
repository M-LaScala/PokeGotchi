using PokéGotchi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokéGotchi.Menu
{
    internal class MenuAdocao : IMenu
    {
        public void ExibirMenu(List<Mascote> mascotes)
        {
            int escolhaMascote, oP;
            Mascote MascoteEscolhido, MascoteAdotado = new();

            Console.Clear();
            ExibeMenuAdocao();

            foreach (Mascote mascote in mascotes)
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
    }
}
