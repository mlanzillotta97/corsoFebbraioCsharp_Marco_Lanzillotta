using System;
using System.Collections.Generic;

class Program
{

        static void Main()
    {
        ListaInteriVuoti();
        ListaDieciNumeri();
        ListaQuindiciNumeri();
    }
    static void ListaInteriVuoti()
    {
        // Crea una lista di interi vuota
        List<int> numeri = new List<int>();

        // Chiede all’utente di inserire 5 numeri interi
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Inserisci il numero {i + 1}: ");
            int numero = int.Parse(Console.ReadLine());
            numeri.Add(numero);
        }

        // Calcola due somme (esempio: primi 2 e ultimi 3 numeri)
        int somma1 = 0;
        int somma2 = 0;

        for (int i = 0; i < 2; i++)
        {
            somma1 += numeri[i];
        }

        for (int i = 2; i < numeri.Count; i++)
        {
            somma2 += numeri[i];
        }

        // Indica quale delle due somme è maggiore
        if (somma1 > somma2)
        {
            Console.WriteLine("La somma dei primi 2 numeri è maggiore.");
        }
        else if (somma2 > somma1)
        {
            Console.WriteLine("La somma degli ultimi 3 numeri è maggiore.");
        }
        else
        {
            Console.WriteLine("Le due somme sono uguali.");
        }

        // Chiede quanti numeri rimuovere
        Console.Write("Quanti numeri vuoi rimuovere? ");
        int quanti = int.Parse(Console.ReadLine());

        for (int i = 0; i < quanti; i++)
        {
            Console.Write("Inserisci il numero da rimuovere: ");
            int daRimuovere = int.Parse(Console.ReadLine());

            if (numeri.Contains(daRimuovere))
            {
                numeri.Remove(daRimuovere);
                Console.WriteLine("Numero rimosso.");
            }
            else
            {
                Console.WriteLine("Numero non presente nella lista.");
            }
        }

        // Stampa tutti i numeri presenti nella lista
        Console.WriteLine("Numeri presenti nella lista:");
        foreach (int n in numeri)
        {
            Console.WriteLine(n);
        }
    }

    static void ListaDieciNumeri()
    {
        Random random = new Random();
        List<int> numeri = new List<int>();

        // Genera 10 numeri casuali tra 1 e 100
        for (int i = 0; i < 10; i++)
        {
            numeri.Add(random.Next(1, 101));
        }

        // Stampa la lista
        Console.WriteLine("Lista generata:");
        foreach (int n in numeri)
        {
            Console.Write(n + " ");
        }
        Console.WriteLine();

        // Chiede all’utente un numero da cercare
        Console.Write("Inserisci un numero da cercare: ");
        int numeroCercato = int.Parse(Console.ReadLine());

        // Controlla se il numero è presente
        if (numeri.Contains(numeroCercato))
        {
            int posizione = numeri.IndexOf(numeroCercato);
            Console.WriteLine($"Numero trovato in posizione (indice): {posizione}");
        }
        else
        {
            Console.WriteLine("Numero non trovato nella lista.");
        }

        // Trova tutti i numeri pari
        List<int> numeriPari = new List<int>();

        foreach (int n in numeri)
        {
            if (n % 2 == 0)
            {
                numeriPari.Add(n);
            }
        }

        // Stampa quanti e quali sono i numeri pari
        Console.WriteLine($"Numeri pari trovati: {numeriPari.Count}");
        Console.WriteLine("Elenco numeri pari:");

        foreach (int pari in numeriPari)
        {
            Console.Write(pari + " ");
        }
    }

    static void ListaQuindiciNumeri()
    {
        Random random = new Random();
        List<int> numeri = new List<int>();

        // Crea una lista di almeno 15 numeri casuali tra 1 e 20 (con duplicati possibili)
        for (int i = 0; i < 15; i++)
        {
            numeri.Add(random.Next(1, 21));
        }

        // Stampa la lista originale
        Console.WriteLine("Lista originale:");
        foreach (int n in numeri)
        {
            Console.Write(n + " ");
        }

        Console.WriteLine();

        // Rimuove i duplicati mantenendo solo i valori unici
        List<int> numeriUnici = numeri.Distinct().ToList();

        // Ordina la lista in ordine crescente
        numeriUnici.Sort();

        // Stampa la lista finale senza duplicati e ordinata
        Console.WriteLine("Lista senza duplicati e ordinata:");
        foreach (int n in numeriUnici)
        {
            Console.Write(n + " ");
        }
    }
}
