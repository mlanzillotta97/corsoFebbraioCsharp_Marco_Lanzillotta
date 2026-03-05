using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<DispositivoElettronico> dispositivi = new List<DispositivoElettronico>();

        dispositivi.Add(new Computer("Dell"));
        dispositivi.Add(new Stampante("HP"));

        Console.WriteLine("=== LABORATORIO TECNICO ===");
        Console.WriteLine("1 - Mostra e usa tutti i dispositivi");
        Console.WriteLine("0 - Esci");
        Console.Write("Scelta: ");

        int scelta = int.Parse(Console.ReadLine());

        if (scelta == 1)
        {
            foreach (DispositivoElettronico dispositivo in dispositivi)
            {
                dispositivo.MostraInfo();
                dispositivo.Accendi();
                dispositivo.Spegni();
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Programma terminato.");
        }
    }
}