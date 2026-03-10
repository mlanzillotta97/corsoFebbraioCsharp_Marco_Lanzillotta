using System;

namespace ObserverMeteo
{
    class Program
    {
        static void Main(string[] args)
        {
            CentroMeteo centro = new CentroMeteo();

            DisplayConsole console = new DisplayConsole();
            DisplayMobile mobile = new DisplayMobile();

            centro.Registra(console);
            centro.Registra(mobile);

            bool continua = true;

            while (continua)
            {
                Console.WriteLine("\nInserisci nuovi dati meteo (oppure 'exit' per uscire):");
                string dati = Console.ReadLine();

                if (dati.ToLower() == "exit")
                {
                    continua = false;
                }
                else
                {
                    centro.AggiornaMeteo(dati);
                }
            }

            Console.WriteLine("Programma terminato.");
        }
    }
}