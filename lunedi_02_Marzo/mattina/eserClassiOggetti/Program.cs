/*

using System;

public class Persona

{
public string Nome;
public int Eta;
// Sovrascrive ToString per personalizzare l'output

public override string ToString()

{
return $"Nome: {Nome}, Età: {Eta}";
}

}
public class Programma
{

public static void Main()

{
Persona p = new Persona { Nome = "Luca", Eta = 25 };
Console.WriteLine(p); // Output: Nome: Luca, Età: 25
}

}


*/
/* 
using System;

public class Punto

{

public int X;

public int Y;

// Sovrascrive Equals per confrontare coordinate

public override bool Equals(object obj)

{

if (obj is Punto altro)

{

return this.X == altro.X && this.Y == altro.Y;

}

return false;

}

}

public class Programma

{

public static void Main()

{

Punto a = new Punto { X = 1, Y = 2 };

Punto b = new Punto { X = 1, Y = 2 };

Console.WriteLine(a.Equals(b));

// Output: True ( oggetti diversi uguali)

}

}

*/

/*
using System;

public class Libro
{
    // Campi pubblici (senza get e set)
    public string Titolo;
    public string Autore;
    public int AnnoPubblicazione;

    public Libro(string titolo, string autore, int annoPubblicazione)
    {
        Titolo = titolo;
        Autore = autore;
        AnnoPubblicazione = annoPubblicazione;
    }

    // Override di ToString()
    public override string ToString()
    {
        return $"\"{Titolo}\" di {Autore} ({AnnoPubblicazione})";
    }

    // Override di Equals()
    public override bool Equals(object obj)
    {
        if (obj is Libro altroLibro)
        {
            return Titolo == altroLibro.Titolo &&
            Autore == altroLibro.Autore;
        }
        return false;
    }

    // Override di GetHashCode()
    public override int GetHashCode()
    {
        return HashCode.Combine(Titolo, Autore);
    }
}

class Program
{
    static void Main()
    {
        Libro libro1 = new Libro("Il Nome della Rosa", "Umberto Eco", 1980);
        Libro libro2 = new Libro("Il Nome della Rosa", "Umberto Eco", 1980);

        // Verifica ToString()
        Console.WriteLine(libro1.ToString());

        // Verifica Equals()
        Console.WriteLine("Equals(): " + libro1.Equals(libro2));

        // Verifica GetHashCode()
        Console.WriteLine("HashCode libro1: " + libro1.GetHashCode());
        Console.WriteLine("HashCode libro2: " + libro2.GetHashCode());
        Console.WriteLine("HashCode uguali: " +
            (libro1.GetHashCode() == libro2.GetHashCode()));
    }
}
*/

/*

using System;

public class Libro
{
    // Campi pubblici
    public string Titolo;
    public string Autore;
    public int AnnoPubblicazione;

    public Libro(string titolo, string autore, int anno)
    {
        Titolo = titolo;
        Autore = autore;
        AnnoPubblicazione = anno;
    }

    // Metodo che usa MemberwiseClone()
    public Libro Clona()
    {
        return (Libro)this.MemberwiseClone();
    }

    // Distruttore (Finalize)
    ~Libro()
    {
        Console.WriteLine($"Oggetto Libro \"{Titolo}\" distrutto.");
    }
}

class Program
{
    static void Main()
    {
        Libro libro1 = new Libro("Il Nome della Rosa", "Umberto Eco", 1980);

        // GetType()
        Console.WriteLine("Tipo oggetto: " + libro1.GetType());

        // MemberwiseClone()
        Libro libroClonato = libro1.Clona();
        Console.WriteLine("Libro clonato: " + libroClonato.Titolo);

        // ReferenceEquals()
        Console.WriteLine("Stesso riferimento (libro1, libroClonato): " +
            Object.ReferenceEquals(libro1, libroClonato));

        Libro libro2 = libro1;
        Console.WriteLine("Stesso riferimento (libro1, libro2): " +
            Object.ReferenceEquals(libro1, libro2));

        // Forziamo Garbage Collector per mostrare Finalize()
        libro1 = null;
        libro2 = null;
        libroClonato = null;

        GC.Collect();
        GC.WaitForPendingFinalizers();

        Console.WriteLine("Fine programma.");
    }
}

*/
/*
using System;

class Program
{
    static void Main()
    {
        Console.Write("Inserisci il tuo nome: ");
        string nome = Console.ReadLine();

        Console.Write("Inserisci credito iniziale: ");
        int credito = int.Parse(Console.ReadLine());

        Utente utente = new Utente(nome, credito);

        // Creazione 3 macchine
        Macchina[] macchine = new Macchina[3];
        macchine[0] = new Macchina("Base");
        macchine[1] = new Macchina("Sport");
        macchine[2] = new Macchina("Turbo");

        Console.WriteLine("\nScegli una macchina (0, 1, 2): ");
        int sceltaMacchina = int.Parse(Console.ReadLine());

        Macchina macchinaScelta = macchine[sceltaMacchina];

        while (utente.Credito > 0)
        {
            Console.WriteLine("\nCredito disponibile: " + utente.Credito);
            Console.WriteLine("1 - Aumenta velocità (+10)");
            Console.WriteLine("2 - Cambia motore");
            Console.WriteLine("3 - Aumenta sospensioni (+1)");
            Console.WriteLine("4 - Esci");

            int scelta = int.Parse(Console.ReadLine());

            if (scelta == 4)
                break;

            switch (scelta)
            {
                case 1:
                    macchinaScelta.AumentaVelocita();
                    utente.Credito--;
                    break;

                case 2:
                    Console.Write("Inserisci nuovo tipo di motore: ");
                    string nuovoMotore = Console.ReadLine();
                    macchinaScelta.CambiaMotore(nuovoMotore);
                    utente.Credito--;
                    break;

                case 3:
                    macchinaScelta.AumentaSospensioni();
                    utente.Credito--;
                    break;

                default:
                    Console.WriteLine("Scelta non valida.");
                    break;
            }
        }

        Console.WriteLine("\nUtente: " + utente.Nome);
        macchinaScelta.StampaDettagli();
    }
}
*/