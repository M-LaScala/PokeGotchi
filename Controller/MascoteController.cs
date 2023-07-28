using PokéGotchi.Models;
using static PokéGotchi.View.MascoteView;
using AutoMapper;
using PokéGotchi.Model;

namespace PokéGotchi.Controller
{
    internal class MascoteController
    {

        public static Mascote ListarMascotePorId(List<Mascote> mascotes, int id)
        {
            Mascote mascote = mascotes.Find(p => p.id == id)!;
            return mascote;
        }
    }
}
