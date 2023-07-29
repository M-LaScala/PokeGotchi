using PokéGotchi.Model;
using RestSharp;
using System.Globalization;
using System.Text.Json;
using System.Xml.Linq;

namespace PokéGotchi.Utilitarios;

internal static class ComunicacaoAPI
{
    public static List<Mascote>? CarregarMascotes(List<string> nomes)
    {

        List<Mascote> mascotes = new();

        /*
         * RestClient  -> Define o cliente    -> URL
         * RestRequest -> Define a requisição -> GET
         */

        int idCount = 0;

        foreach (string nome in nomes)
        {
            var client = new RestClient($"https://pokeapi.co/api/v2/pokemon/{nome}");
            RestRequest request = new("", Method.Get);
            var response = client.Execute(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK && response.Content != null)
            {
                // Adiciona a resposta da API de forma Deserializada na lista de mascotes
                mascotes.Add(JsonSerializer.Deserialize<Mascote>(response.Content)!); // ! operador indicando que não pode ser nullo   
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

    public static bool BuscarMascote(List<Mascote> mascotes,String nome)
    {
        var client = new RestClient($"https://pokeapi.co/api/v2/pokemon/{nome}");
        RestRequest request = new("", Method.Get);
        var response = client.Execute(request);

        // Pega o ID do ultimo mascote para acrescentar o proximo
        int idCount = mascotes.Last().id;
        idCount++;

        if (response.StatusCode == System.Net.HttpStatusCode.OK && response.Content != null)
        {
            // Adiciona a resposta da API de forma Deserializada na lista de mascotes caso o mascote não exita na lista ainda
            if (mascotes.FindAll(x => x.Nome == CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nome)).Count() == 0)
            {
                mascotes.Add(JsonSerializer.Deserialize<Mascote>(response.Content)!); // ! operador indicando que não pode ser nullo   
                mascotes[idCount].id = idCount;
                return true;
            }
            else
            {
                // Mascote já exite na lista
                return false;
            }
            
        }
        else
        {
            // Verifica se ErrorMessage esta null e exibe a msg 
            Console.WriteLine(response.ErrorMessage ?? "Erro não definido pela API!");
            return false;
        }
    }

}

