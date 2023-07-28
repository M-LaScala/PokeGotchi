using PokéGotchi.Menu;
using PokéGotchi.Model;
using PokéGotchi.Utilitarios;

internal class Program
{
    private static void Main()
    {
        // Definindo as criaturas iniciais
        List<string> names = new()
            {
                "eevee",
                "togepi",
                "ditto",
                "piplup",
                "fennekin",
                "minun",
                "plusle",
                "sylveon",
                "cinccino",
                "zorua"
            };

        List<Mascote> mascotes = ComunicacaoAPI.CarregarMascotes(names)!;

        if (mascotes is null)
        {
            Console.WriteLine("Erro no programa!");
            return;
        }

        MenuPrincipal menuPrincipal = new();
        menuPrincipal.ExibirMenu(mascotes);
    }
}