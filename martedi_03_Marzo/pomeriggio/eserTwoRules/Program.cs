using System;
using System.Collections.Generic;

namespace Esercito
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Soldato> esercito = new List<Soldato>();
            int scelta;

            do
            {
                Console.WriteLine("\n--- MENU ESERCITO ---");
                Console.WriteLine("[1] Aggiungi Fante");
                Console.WriteLine("[2] Aggiungi Artigliere");
                Console.WriteLine("[3] Visualizza tutti i soldati");
                Console.WriteLine("[0] Esci");
                Console.Write("Scelta: ");

                scelta = int.Parse(Console.ReadLine());

                switch (scelta)
                {
                    case 1:
                        Console.Write("Nome: ");
                        string nomeF = Console.ReadLine();

                        Console.Write("Grado: ");
                        string gradoF = Console.ReadLine();

                        Console.Write("Anni di servizio: ");
                        int anniF = int.Parse(Console.ReadLine());

                        Console.Write("Arma: ");
                        string arma = Console.ReadLine();

                        esercito.Add(new Fante(nomeF, gradoF, anniF, arma));
                        break;

                    case 2:
                        Console.Write("Nome: ");
                        string nomeA = Console.ReadLine();

                        Console.Write("Grado: ");
                        string gradoA = Console.ReadLine();

                        Console.Write("Anni di servizio: ");
                        int anniA = int.Parse(Console.ReadLine());

                        Console.Write("Calibro: ");
                        int calibro = int.Parse(Console.ReadLine());

                        esercito.Add(new Artigliere(nomeA, gradoA, anniA, calibro));
                        break;

                    case 3:
                        if (esercito.Count == 0)
                        {
                            Console.WriteLine("Nessun soldato presente.");
                        }
                        else
                        {
                            foreach (Soldato s in esercito)
                            {
                                s.Descrizione(); // Polimorfismo
                            }
                        }
                        break;

                    case 0:
                        Console.WriteLine("Uscita dal programma.");
                        break;

                    default:
                        Console.WriteLine("Scelta non valida.");
                        break;
                }

            } while (scelta != 0);
        }
    }
}