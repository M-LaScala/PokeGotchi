using System.Text.Json.Serialization;

namespace PokéGotchi.Models;

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

internal class Monstro
{
    [JsonPropertyName("name")]
    public string Nome { get; set; }

    [JsonPropertyName("height")]
    public int Altura { get; set; }

    [JsonPropertyName("weight")]
    public int Peso { get; set; }

    [JsonPropertyName("abilities")]
    public List<Habilidades> Habilidades { get; set; }

    [JsonPropertyName("types")]
    public List<Tipos> Tipos { get; set; }

    public void ExibirMonstro()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Altura: {Altura}");
        Console.WriteLine($"Peso: {Peso}");
        Console.WriteLine($"Habilidades: ");
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
