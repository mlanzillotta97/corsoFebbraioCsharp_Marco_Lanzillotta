using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Film> videoteca = new List<Film>();

        Console.WriteLine("Quanti film vuoi inserire? (minimo 3)");
        int numeroFilm = int.Parse(Console.ReadLine());

        if (numeroFilm < 3)
            numeroFilm = 3;

        // Inserimento film
        for (int i = 0; i < numeroFilm; i++)
        {
            Console.WriteLine($"\nInserisci i dati del film {i + 1}");

            Console.Write("Titolo: ");
            string titolo = Console.ReadLine();

            Console.Write("Regista: ");
            string regista = Console.ReadLine();

            Console.Write("Anno: ");
            int anno = int.Parse(Console.ReadLine());

            Console.Write("Genere: ");
            string genere = Console.ReadLine();

            Film nuovoFilm = new Film(titolo, regista, anno, genere);
            videoteca.Add(nuovoFilm);
        }

        // Stampa tutti i film
        Console.WriteLine("\n--- TUTTI I FILM INSERITI ---");
        foreach (Film film in videoteca)
        {
            film.Stampa();
        }

        // Ricerca per genere
        Console.Write("\nInserisci un genere da cercare: ");
        string genereRicerca = Console.ReadLine();

        Console.WriteLine($"\n--- FILM DI GENERE {genereRicerca} ---");

        foreach (Film film in videoteca)
        {
            if (film.Genere.ToLower() == genereRicerca.ToLower())
            {
                film.Stampa();
            }
        }
    }
}