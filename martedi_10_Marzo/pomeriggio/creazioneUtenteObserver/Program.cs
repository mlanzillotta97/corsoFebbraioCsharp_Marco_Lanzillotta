using System;

namespace ObserverUtenti
{
    class Program
    {
        static void Main(string[] args)
        {
            GestoreCreazioneUtente gestore = new GestoreCreazioneUtente();

            ModuloLog log = new ModuloLog();
            ModuloMarketing marketing = new ModuloMarketing();

            bool logRegistrato = false;
            bool marketingRegistrato = false;

            bool continua = true;

            while (continua)
            {
                Console.WriteLine("\n===== GESTIONE UTENTI =====");
                Console.WriteLine("1 - Registra Modulo Log");
                Console.WriteLine("2 - Registra Modulo Marketing");
                Console.WriteLine("3 - Crea nuovo utente");
                Console.WriteLine("4 - Rimuovi Modulo Log");
                Console.WriteLine("5 - Rimuovi Modulo Marketing");
                Console.WriteLine("0 - Esci");
                Console.Write("Scelta: ");

                string scelta = Console.ReadLine();

                switch (scelta)
                {
                    case "1":
                        if (!logRegistrato)
                        {
                            gestore.Registra(log);
                            logRegistrato = true;
                            Console.WriteLine("Modulo Log registrato.");
                        }
                        else
                        {
                            Console.WriteLine("Modulo Log già registrato.");
                        }
                        break;

                    case "2":
                        if (!marketingRegistrato)
                        {
                            gestore.Registra(marketing);
                            marketingRegistrato = true;
                            Console.WriteLine("Modulo Marketing registrato.");
                        }
                        else
                        {
                            Console.WriteLine("Modulo Marketing già registrato.");
                        }
                        break;

                    case "3":
                        Console.Write("Inserisci nome utente: ");
                        string nome = Console.ReadLine();
                        gestore.CreaUtente(nome);
                        break;

                    case "4":
                        gestore.Rimuovi(log);
                        logRegistrato = false;
                        Console.WriteLine("Modulo Log rimosso.");
                        break;

                    case "5":
                        gestore.Rimuovi(marketing);
                        marketingRegistrato = false;
                        Console.WriteLine("Modulo Marketing rimosso.");
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