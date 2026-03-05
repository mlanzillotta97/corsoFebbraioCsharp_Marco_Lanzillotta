using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Corso> corsi = new List<Corso>();

        Docente d1 = new Docente("Mario Rossi", "Programmazione");
        Docente d2 = new Docente("Laura Bianchi", "Database");

        corsi.Add(new CorsoInPresenza("C# Base", 40, d1, "Aula 3", 20));
        corsi.Add(new CorsoOnline("SQL Avanzato", 30, d2, "Zoom", "www.zoom.it/sql"));

        Console.WriteLine("=== GESTIONE CORSI ===");
        Console.WriteLine("1 - Mostra corsi");
        Console.WriteLine("0 - Esci");
        Console.Write("Scelta: ");

        int scelta = int.Parse(Console.ReadLine());

        if (scelta == 1)
        {
            foreach (Corso c in corsi)
            {
                Console.WriteLine("---------------------");
                c.StampaDettagli();
                c.ErogaCorso();
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Programma terminato.");
        }
    }
}