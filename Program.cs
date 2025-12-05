using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        var configuration = AppConfig.GetConfiguration();

        Console.Clear();
        Console.WriteLine("Inserisci la birra da cercare:");
        string? birra_cercare = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(birra_cercare))
            birra_cercare = "Duff";

        var birreDb = BirraCrud.CercaPerBrewery(birra_cercare);

        if (birreDb.Count > 0)
        {
            Console.WriteLine("Birre trovate nel DB:");
            BirraCrud.VisualizzaBirre(birreDb);
        }
        else
        {
            var apiResult = await ApiManager.GetBirreAsync(configuration, birra_cercare);

            if (apiResult?.data != null)
            {
                BirraCrud.SalvaBirre(apiResult.data);
                Console.WriteLine("Birre trovate tramite API:");
                BirraCrud.VisualizzaBirre(apiResult.data);
            }
            else
            {
                Console.WriteLine("Nessuna birra trovata tramite API.");
            }
        }
    }
}
