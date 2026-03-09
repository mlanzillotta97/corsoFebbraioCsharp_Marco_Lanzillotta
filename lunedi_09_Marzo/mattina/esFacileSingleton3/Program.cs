using System;

class Program
{
    static void Main(string[] args)
    {
        int scelta;

        do
        {
            Console.WriteLine("=== MENU LOGGER ===");
            Console.WriteLine("1. Aggiungi log (istanza 1)");
            Console.WriteLine("2. Aggiungi log (istanza 2)");
            Console.WriteLine("3. Mostra tutti i log");
            Console.WriteLine("0. Esci");
            Console.Write("Scelta: ");

            scelta = int.Parse(Console.ReadLine());

            switch (scelta)
            {
                case 1:
                    Logger logger1 = Logger.Instance;
                    Console.Write("Inserisci messaggio: ");
                    string msg1 = Console.ReadLine();
                    logger1.Log(msg1);
                    break;

                case 2:
                    Logger logger2 = Logger.Instance;
                    Console.Write("Inserisci messaggio: ");
                    string msg2 = Console.ReadLine();
                    logger2.Log(msg2);
                    break;

                case 3:
                    Console.WriteLine("\n--- LOG SALVATI ---");
                    Logger.Instance.StampaLog();
                    break;
            }

            Console.WriteLine();

        } while (scelta != 0);
    }
}