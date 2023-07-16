// See https://aka.ms/new-console-template for more information
using PokéGotchi.Models;
using RestSharp;
using System.Text.Json;
using static PokéGotchi.Controller.MascoteController;

Main();

static void Main()
{
    List<MascoteModel>? mascotes = new();

    mascotes = CarregarMascotes();

    if (mascotes is null)
    {
        Console.WriteLine("Erro no programa!");
        return;
    }

    MenuPrincipal(mascotes);
}

static List<MascoteModel>? CarregarMascotes()
{
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

    List<MascoteModel> mascotes = new List<MascoteModel>();

    /*
     * RestClient  -> Define o cliente    -> URL
     * RestRequest -> Define a requisição -> GET
     */

    int idCount = 0;

    foreach (string name in names)
    {
        var client = new RestClient($"https://pokeapi.co/api/v2/pokemon/{name}");
        RestRequest request = new RestRequest("", Method.Get);
        var response = client.Execute(request);

        if (response.StatusCode == System.Net.HttpStatusCode.OK && response.Content != null)
        {
            // Adiciona a resposta da API de forma Deserializada na lista de mascotes
            mascotes.Add(JsonSerializer.Deserialize<MascoteModel>(response.Content)!); // ! operador indicando que não pode ser nullo   
            mascotes[idCount].id = idCount;
            idCount++;
        }
        else
        {
            // Verifica se ErrorMessage esta null e exibe a msg 
            Console.WriteLine(response.ErrorMessage ?? "Erro não definido pela API!");
        }
    }

    if (mascotes.Count > 0)
    {
        return mascotes;
    }
    else
    {
        Console.WriteLine("Nada foi consumido da API!");
        return null;
    }

}
