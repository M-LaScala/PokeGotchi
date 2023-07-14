// See https://aka.ms/new-console-template for more information
using PokéGotchi.Models;
using RestSharp;

Console.WriteLine("Start Here!");
Main();

// Eevee - Togepi - Ditto - Piplup - Fennekin
// Minun - Plusle - Sylveon - Cinccino - zorua

static void Main()
{
    List<Monstro> monstros = new List<Monstro>();

    /*
     * RestClient  -> Define o cliente    -> URL
     * RestRequest -> Define a requisição -> GET
     */

    var client = new RestClient($"https://pokeapi.co/api/v2/pokemon?offset=0&limte=1281"); //  https://pokeapi.co/api/v2/pokemon
    RestRequest request = new RestRequest("", Method.Get);
    var response = client.Execute(request);

    if (response.StatusCode == System.Net.HttpStatusCode.OK)
    {
        Console.WriteLine(response.Content);
    }
    else
    {
        // Verifica se ErrorMessage esta null e exibe a msg 
        Console.WriteLine(response.ErrorMessage ?? "Erro não definido pela API!");
    }

}
