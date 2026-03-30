public class Program
{
    public static void Main()
    {
        using var db = new ProdottiContext();

        // Crea DB e tabella se non esistono
        db.Database.EnsureCreated();

        // 🔹 1) CREATE
        var nuovo = new Prodotto { Nome = "Mouse", Prezzo = 15.50m };
        db.Prodotti.Add(nuovo);
        db.SaveChanges();

        Console.WriteLine($"Creato prodotto Id={nuovo.Id}");

        // 🔹 2) READ
        var lista = db.Prodotti.ToList();

        Console.WriteLine("\nLista prodotti:");
        foreach (var p in lista)
            Console.WriteLine($"{p.Id} - {p.Nome} - {p.Prezzo}€");

        // 🔹 3) UPDATE
        var first = db.Prodotti.FirstOrDefault();

        if (first != null)
        {
            first.Nome = "Mouse Gaming";
            first.Prezzo = 25.99m;

            db.SaveChanges();

            Console.WriteLine($"Aggiornato Id={first.Id}");
        }

        // 🔹 4) DELETE
        var daEliminare = db.Prodotti.OrderByDescending(p => p.Id).FirstOrDefault();

        if (daEliminare != null)
        {
            db.Prodotti.Remove(daEliminare);
            db.SaveChanges();

            Console.WriteLine($"Eliminato Id={daEliminare.Id}");
        }
    }
}