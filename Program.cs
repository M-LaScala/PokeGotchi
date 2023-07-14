// See https://aka.ms/new-console-template for more information
using PokéGotchi.Models;
using RestSharp;
using System.Text.Json;

Console.WriteLine("Start Here!");
Main();

static void Main()
{
    ListaMonstros();
}

static void ListaMonstros()
{
    List<string> names = new List<string>
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

    List<Monstro> monstros = new List<Monstro>();

    /*
     * RestClient  -> Define o cliente    -> URL
     * RestRequest -> Define a requisição -> GET
     */

    foreach (string name in names)
    {
        var client = new RestClient($"https://pokeapi.co/api/v2/pokemon/{name}");
        RestRequest request = new RestRequest("", Method.Get);
        var response = client.Execute(request);

        if (response.StatusCode == System.Net.HttpStatusCode.OK && response.Content != null)
        {
            monstros.Add(JsonSerializer.Deserialize<Monstro>(response.Content)!); // ! operador indicando que não pode ser nullo   
        }
        else
        {
            // Verifica se ErrorMessage esta null e exibe a msg 
            Console.WriteLine(response.ErrorMessage ?? "Erro não definido pela API!");
        }
    }

    int cont = 1;
    foreach (Monstro monstro in monstros)
    {
        Console.WriteLine("---------------------------------------");
        Console.WriteLine($"Criatura nº{cont}");
        monstro.ExibirMonstro();
        cont++;
    }

}
