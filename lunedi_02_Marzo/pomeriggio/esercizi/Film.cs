using System;
using System.Collections.Generic;


public class Film
{
    public string Titolo;
    public string Regista;
    public int Anno;
    public string Genere;

    public Film(string titolo, string regista, int anno, string genere)
    {
        Titolo = titolo;
        Regista = regista;
        Anno = anno;
        Genere = genere;
    }

    public void Stampa()
    {
        Console.WriteLine($"Titolo: {Titolo}");
        Console.WriteLine($"Regista: {Regista}");
        Console.WriteLine($"Anno: {Anno}");
        Console.WriteLine($"Genere: {Genere}");
        Console.WriteLine("------------------------");
    }
}