// Modello dominio
public class Program

{

    public static void Main()

    {
        using var db = new ScuolaContext();

        // Opzionale: crea il DB e le tabelle se non esistono

        db.Database.EnsureCreated();

        // 1) CREATE: inserisce un nuovo Studente

        var nuovo = new Studente { Nome = "Luca", Cognome = "Rossi" };

        db.Studenti.Add(nuovo);

        db.SaveChanges();

        Console.WriteLine($"Creato studente Id={nuovo.Id}");

        // 2) READ (filtrato): legge tutti gli studenti con Cognome = "Rossi"

        var rossi = db.Studenti.Where(s => s.Cognome == "Rossi").ToList();

        Console.WriteLine("Studenti Rossi:");

        foreach (var s in rossi)

            Console.WriteLine($"{s.Id} - {s.Nome} {s.Cognome}");

        // 3) UPDATE: modifica il Nome del primo studente trovato

        var first = db.Studenti.FirstOrDefault();

        if (first != null)

        {

            first.Nome = "Marco";

            db.SaveChanges();

            Console.WriteLine($"Aggiornato Id={first.Id} -> Nome={first.Nome}");

        }

    }

}


