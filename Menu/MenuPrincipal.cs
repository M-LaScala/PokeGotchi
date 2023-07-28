using AutoMapper;
using PokéGotchi.Models;
using static PokéGotchi.View.MascoteView;

namespace PokéGotchi.Menu
{
    internal class MenuPrincipal : IMenu
    {
        public void ExibirMenu(List<Mascote> mascotes)
        {

            int oP;
            Mascote? MascoteRecebido = new();
            MascoteAdotado MascoteAdotado = new();

            Console.Clear(); ExibeLogo(); ExibeMenuInicial();

            // Configurando o AutoMapper os objetos a serem mapeados ( Origem -> Destino )
            var Config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Mascote, MascoteAdotado>()
                .ForMember(dest => dest.Habilidades, opt => opt.MapFrom(src => src.Habilidades));
            });

            // Definindo o mapper
            var mapper = Config.CreateMapper();

            do
            {

                try { oP = int.Parse(Console.ReadLine() ?? "0"); } catch { oP = -1; };

                switch (oP)
                {
                    case (int)MenuOpc.ADOTAR_MASCOTE:
                        MascoteRecebido = AdotarMascote(mascotes);
                        //Mapeando o objeto
                        MascoteAdotado = mapper.Map<MascoteAdotado>(MascoteRecebido);
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

    }
}
