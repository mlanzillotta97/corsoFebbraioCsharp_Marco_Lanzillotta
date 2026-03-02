using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<Veicolo> garage = new List<Veicolo>();
        bool continua = true;

        while (continua)
        {
            Console.WriteLine("\n--- MENU GARAGE ---");
            Console.WriteLine("1. Inserisci Auto");
            Console.WriteLine("2. Inserisci Moto");
            Console.WriteLine("3. Visualizza veicoli");
            Console.WriteLine("4. Esci");
            Console.Write("Scelta: ");

            string scelta = Console.ReadLine();

            switch (scelta)
            {
                case "1":
                    Console.Write("Marca: ");
                    string marcaAuto = Console.ReadLine();

                    Console.Write("Modello: ");
                    string modelloAuto = Console.ReadLine();

                    Console.Write("Numero porte: ");
                    int porte = int.Parse(Console.ReadLine());

                    garage.Add(new Auto(marcaAuto, modelloAuto, porte));
                    Console.WriteLine("Auto inserita!");
                    break;

                case "2":
                    Console.Write("Marca: ");
                    string marcaMoto = Console.ReadLine();

                    Console.Write("Modello: ");
                    string modelloMoto = Console.ReadLine();

                    Console.Write("Tipo manubrio: ");
                    string manubrio = Console.ReadLine();

                    garage.Add(new Moto(marcaMoto, modelloMoto, manubrio));
                    Console.WriteLine("Moto inserita!");
                    break;

                case "3":
                    Console.WriteLine("\n--- VEICOLI NEL GARAGE ---");

                    if (garage.Count == 0)
                    {
                        Console.WriteLine("Nessun veicolo presente.");
                    }
                    else
                    {
                        foreach (Veicolo v in garage)
                        {
                            v.StampaInfo(); // Polimorfismo
                        }
                    }
                    break;

                case "4":
                    continua = false;
                    break;

                default:
                    Console.WriteLine("Scelta non valida.");
                    break;
            }
        }
    }
}