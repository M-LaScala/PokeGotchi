using PokéGotchi.Model;

namespace PokéGotchi.Utilitarios
{
    internal class Filtros
    {
        public static Mascote ListarMascotePorId(List<Mascote> mascotes, int id) 
        { 
           Mascote mascote = mascotes.Find(x => x.id == id)!;
           return mascote;
        }
    }
}
