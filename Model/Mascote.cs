using System.Globalization;
using System.Text.Json.Serialization;

namespace PokéGotchi.Model;

public class Habilidades
{
    [JsonPropertyName("ability")]
    public Habilidade habilidade { get; set; }
}

public class Habilidade
{
    [JsonPropertyName("name")]
    public string NomeHabilidade { get; set; }
}

public class Tipos
{
    [JsonPropertyName("type")]
    public Tipo tipo { get; set; }
}

public class Tipo
{
    [JsonPropertyName("name")]
    public string NomeTipo { get; set; }
}

internal class Mascote
{
    private string nome;

    public int id { get; set; }

    [JsonPropertyName("name")]
    public string Nome 
    { 
        get { return nome; } 
        set { nome = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value); }
    }

    [JsonPropertyName("height")]
    public int Altura { get; set; }

    [JsonPropertyName("weight")]
    public int Peso { get; set; }

    [JsonPropertyName("abilities")]
    public List<Habilidades> Habilidades { get; set; }

    [JsonPropertyName("types")]
    public List<Tipos> Tipos { get; set; }

    public void ExibirMascote()
    {
        Console.WriteLine($"nº{id} - {Nome}");
    }

    public void ExibirDetalhesMascote()
    {
        Console.WriteLine("----------------------------- DETALHES -------------------------------");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Altura: {Altura}");
        Console.WriteLine($"Peso: {Peso}");
        Console.WriteLine($"Habilidade(s): ");
        foreach (var hNome in Habilidades)
        {
            Console.WriteLine(hNome.habilidade.NomeHabilidade);
        }
        Console.WriteLine($"Tipo(s): ");
        foreach (var tNome in Tipos)
        {
            Console.WriteLine(tNome.tipo.NomeTipo);
        }
    }
}
