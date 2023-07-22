using PokéGotchi.Models;
using static PokéGotchi.View.MascoteView;
using AutoMapper;
using PokéGotchi.Model;

namespace PokéGotchi.Controller
{
    internal class MascoteController
    {

        public static void MenuPrincipal(List<MascoteDTO> mascotes)
        {

            int oP;
            MascoteDTO? MascoteRecebido = new();
            MascoteAdotado MascoteAdotado = new();

            Console.Clear(); ExibeLogo(); ExibeMenuInicial();

            // Configurando o AutoMapper os objetos a serem mapeados ( Origem -> Destino )
            var Config = new MapperConfiguration(cfg => 
            {
                cfg.CreateMap<MascoteDTO, MascoteAdotado>()
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

        public static MascoteDTO? AdotarMascote(List<MascoteDTO> mascotes)
        {

            int escolhaMascote, oP;
            MascoteDTO MascoteEscolhido, MascoteAdotado = new();
            
            Console.Clear();
            ExibeMenuAdocao();

            foreach (MascoteDTO mascote in mascotes)
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

        public static void VerMascote(MascoteAdotado mascote)
        {
            int oP = -1;

            Console.Clear();
            

            do
            {
                if(oP != (int)MenuMascote.VOLTAR)
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
        public static MascoteDTO ListarMascotePorId(List<MascoteDTO> mascotes, int id)
        {
            MascoteDTO mascote = mascotes.Find(p => p.id == id)!;
            return mascote;
        }
    }
}
