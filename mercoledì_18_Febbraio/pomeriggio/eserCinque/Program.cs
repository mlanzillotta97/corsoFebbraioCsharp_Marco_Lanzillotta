using System;

class Program
{
    static void Main()
    {
        Console.Write("Inserisci una frase: ");
        string testo = Console.ReadLine();

        AnalizzaTesto(testo, out int parole, out int lettere, out int spazi, out int punteggiatura);

        Console.WriteLine("\n--- RISULTATO ---");
        Console.WriteLine("Numero di parole: " + parole);
        Console.WriteLine("Numero di caratteri alfabetici: " + lettere);
        Console.WriteLine("Numero di spazi: " + spazi);
        Console.WriteLine("Numero di segni di punteggiatura: " + punteggiatura);
    }

    static void AnalizzaTesto(string testo, out int numeroParole, out int lettere, out int spazi, out int punteggiatura)
    {
        lettere = 0;
        spazi = 0;
        punteggiatura = 0;

        // Conteggio lettere, spazi e punteggiatura
        foreach (char c in testo)
        {
            if (char.IsLetter(c))
                lettere++;

            if (char.IsWhiteSpace(c))
                spazi++;

            if (char.IsPunctuation(c))
                punteggiatura++;
        }

        // Conteggio parole
        string[] paroleArray = testo.Split(' ');
        numeroParole = 0;

        foreach (string parola in paroleArray)
        {
            if (!string.IsNullOrWhiteSpace(parola))
                numeroParole++;
        }
    }
}
