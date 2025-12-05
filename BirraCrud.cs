using System.Collections.Generic;
using System.Linq;
using System;

public static class BirraCrud
{
    public static void SalvaBirre(List<Birrerie> lista)
    {
        using (var db = new ApplicationDbContext())
        {
            foreach (var item in lista)
                db.Birreries.Add(item);

            db.SaveChanges();
        }
    }

    public static List<Birrerie> CercaPerBrewery(string brewery)
    {
        using (var db = new ApplicationDbContext())
        {
            return db.Birreries
                .Where(x => x.Brewery != null && x.Brewery.Contains(brewery))
                .ToList();
        }
    }

      public static List<Birrerie> Tutte()
    {
        using (var db = new ApplicationDbContext())
        {
            return db.Birreries.ToList();
        }
    }

    public static void VisualizzaBirre(List<Birrerie> lista)
    {
        if (lista.Count == 0)
        {
            Console.WriteLine("Nessuna birra trovata.");
            return;
        }

        foreach (var birra in lista)
            Console.WriteLine($"{birra.Name}\n\tAzienda:{birra.Brewery}\n\tGradazione Alcolica:{birra.Abv}\n\tNazione:{birra.Country}\tRegione:{birra.Region}\n******");
    }
}
