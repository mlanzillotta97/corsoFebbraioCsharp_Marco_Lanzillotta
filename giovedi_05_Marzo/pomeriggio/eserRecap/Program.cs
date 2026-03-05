using System;
using System.Collections.Generic; 

//POLIMORFISMO + MENU 

class Program
{
    static void Main()
    {
        List<Persona> persone = new List<Persona>();
        
        AccessoLog log = new AccessoLog();

        persone.Add(new Dipendente(1, "Marco Rossi", "IT"));
        persone.Add(new Visitatore(2, "Luca Bianchi", "TechCorp"));

        int scelta = -1;

        while (scelta != 0)
        {
            Console.WriteLine("\n=== SISTEMA ACCESSI AZIENDALI ===");
            Console.WriteLine("1 - Inserisci Dipendente");
            Console.WriteLine("2 - Inserisci Visitatore");
            Console.WriteLine("3 - Mostra persone");
            Console.WriteLine("4 - Registra entrata");
            Console.WriteLine("0 - Esci");

            scelta = int.Parse(Console.ReadLine());

            switch (scelta)
            {

                case 1:
                    Console.Write("ID: ");
                    int idDip = int.Parse(Console.ReadLine());

                    Console.Write("Nome: ");
                    string nomeDip = Console.ReadLine();

                    Console.Write("Reparto: ");
                    string reparto = Console.ReadLine();

                    persone.Add(new Dipendente(idDip, nomeDip, reparto));
                    Console.WriteLine("Dipendente inserito!");
                    break;


                case 2:
                    Console.Write("ID: ");
                    int idVis = int.Parse(Console.ReadLine());

                    Console.Write("Nome: ");
                    string nomeVis = Console.ReadLine();

                    Console.Write("Azienda: ");
                    string azienda = Console.ReadLine();

                    persone.Add(new Visitatore(idVis, nomeVis, azienda));
                    Console.WriteLine("Visitatore inserito!");
                    break;


                case 3:
                    Console.WriteLine("\n--- ELENCO PERSONE ---");

                    foreach (Persona p in persone)
                    {
                        Console.WriteLine("ID: " + p.Id + " Nome: " + p.Nome);
                        p.MostraRuolo();
                        Console.WriteLine();
                    }
                    break;


                case 4:
                    foreach (Persona p in persone)
                    {
                        log.RegistraEntrata(p);
                    }
                    break;


                case 0:
                    Console.WriteLine("Uscita dal sistema...");
                    break;


                default:
                    Console.WriteLine("Scelta non valida");
                    break;
            }
        }
    }
}