using AutoMapper;
using PokéGotchi.Model;
using PokéGotchi.Utilitarios;
using static PokéGotchi.View.PokeGotchiView;

namespace PokéGotchi.Menu
{
    internal class MenuAdocao
    {

        private readonly Dictionary<int, string> MenuOpc = new()
        {
                {0, "Saber Mais" },
                {1, "Adotar esse mascote" },
                {2, "Voltar" }
        };

        public static void ExibirMenu(List<Mascote> mascotes)
        {
            // Configurando o AutoMapper os objetos a serem mapeados ( Origem -> Destino )
            var Config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Mascote, MascoteAdotado>()
                .ForMember(dest => dest.Habilidades, opt => opt.MapFrom(src => src.Habilidades));
            });

            // Definindo o mapper
            var mapper = Config.CreateMapper();

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
                MascoteEscolhido = Filtros.ListarMascotePorId(mascotes, escolhaMascote);

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
