using System;

namespace ObserverUtenti
{
    class Program
    {
        static void Main(string[] args)
        {
            GestoreCreazioneUtente gestore = GestoreCreazioneUtente.Instance;

            ModuloLog log = new ModuloLog();
            ModuloMarketing marketing = new ModuloMarketing();

            bool continua = true;

            while (continua)
            {
                Console.WriteLine("\n===== GESTIONE UTENTI =====");
                Console.WriteLine("1 - Registra Modulo Log");
                Console.WriteLine("2 - Registra Modulo Marketing");
                Console.WriteLine("3 - Crea nuovo utente");
                Console.WriteLine("4 - Verifica Singleton");
                Console.WriteLine("0 - Esci");
                Console.Write("Scelta: ");

                string scelta = Console.ReadLine();

                switch (scelta)
                {
                    case "1":
                        gestore.Registra(log);
                        Console.WriteLine("Modulo Log registrato.");
                        break;

                    case "2":
                        gestore.Registra(marketing);
                        Console.WriteLine("Modulo Marketing registrato.");
                        break;

                    case "3":
                        Console.Write("Inserisci nome utente: ");
                        string nome = Console.ReadLine();
                        gestore.CreaUtente(nome);
                        break;

                    case "4":
                        var g1 = GestoreCreazioneUtente.Instance;
                        var g2 = GestoreCreazioneUtente.Instance;

                        Console.WriteLine("Stessa istanza?");
                        Console.WriteLine(Object.ReferenceEquals(g1, g2));
                        break;

                    case "0":
                        continua = false;
                        break;

                    default:
                        Console.WriteLine("Scelta non valida.");
                        break;
                }
            }

            Console.WriteLine("Programma terminato.");
        }
    }
}