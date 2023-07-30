using AutoMapper;
using PokéGotchi.Model;
using PokéGotchi.Utilitarios;
using System;
using static PokéGotchi.View.PokeGotchiView;

namespace PokéGotchi.Menu
{
    internal class MenuAdocao
    {

        private static readonly Dictionary<int, string> MenuOpc = new()
        {
                {0, "Saber Mais" },
                {1, "Adotar esse mascote" },
                {2, "Voltar" }
        };

        public static void ExibirMenu(ref List<Mascote> mascotes, ref MascoteAdotado mascoteAdotado)
        {

            Mascote mascoteEscolhido = new();
            int escolhaMascote, opc = -1;

            // Configurando o AutoMapper os objetos a serem mapeados ( Origem -> Destino )
            var Config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Mascote, MascoteAdotado>()
                .ForMember(dest => dest.Habilidades, opt => opt.MapFrom(src => src.Habilidades));
            });

            // Definindo o mapper
            var mapper = Config.CreateMapper();

            Console.Clear();
            ExibirMenuAdocao();

            foreach (Mascote mascote in mascotes)
            {
                mascote.ExibirMascote();
            }

            do
            {
                try { escolhaMascote = int.Parse(Console.ReadLine() ?? "0"); } catch { escolhaMascote = -1; }
                mascoteEscolhido = Filtros.ListarMascotePorId(mascotes, escolhaMascote);

                if (mascoteEscolhido == null)
                {
                    ExibirErroEncontrarOpcao();
                }

            } while (mascoteEscolhido == null);

            ExibirMenus(MenuOpc, "Menu adocao");

            do
            {

                if (opc != -1)
                {
                    ExibirMenus(MenuOpc, "Menu adocao");
                }

                try { opc = int.Parse(Console.ReadLine() ?? "0"); } catch { opc = -1; };

                if (MenuOpc.ContainsKey(opc))
                {
                    switch (opc)
                    {
                        case 0:
                            mascoteEscolhido.ExibirDetalhesMascote();
                            break;

                        case 1:
                            ExibirAdocao(mascoteEscolhido);
                            mascoteAdotado = mapper.Map<MascoteAdotado>(mascoteEscolhido);
                            Console.ReadLine();
                            break;

                        case 2:
                            break;

                        default:
                            break;
                    }
                }
                else
                {
                    ExibirErroEncontrarOpcao();
                }

            } while (opc != 2 && opc != 1);
        }
    }
}
