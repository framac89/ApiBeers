using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using RestSharp;
public static class ApiManager
{
    public static async Task<Root?> GetBirreAsync(IConfiguration configuration, string birra)
    {
        var apiKey = configuration["mykeyAPI"]!;
        var client = new RestClient($"https://beer9.p.rapidapi.com/?brewery={birra}");
        var request = new RestRequest("", Method.Get);
        request.AddHeader("x-rapidapi-key", apiKey);
        request.AddHeader("x-rapidapi-host", "beer9.p.rapidapi.com");

        var response = await client.ExecuteAsync<Root>(request);
        if (response.IsSuccessful && response.Data?.data != null && response.Data.data.Count > 0)
            return response.Data;

        return null;
    }
}