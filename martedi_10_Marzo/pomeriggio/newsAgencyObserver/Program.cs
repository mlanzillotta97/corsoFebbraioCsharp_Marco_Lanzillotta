using System;

namespace NewsObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            NewsAgency agency = NewsAgency.Instance;

            MobileApp mobile = new MobileApp();
            EmailClient email = new EmailClient();

            bool mobileRegistrato = false;
            bool emailRegistrato = false;

            bool continua = true;

            while (continua)
            {
                Console.WriteLine("\n===== NEWS AGENCY =====");
                Console.WriteLine("1 - Registra MobileApp");
                Console.WriteLine("2 - Registra EmailClient");
                Console.WriteLine("3 - Inserisci nuova News");
                Console.WriteLine("4 - Rimuovi MobileApp");
                Console.WriteLine("5 - Rimuovi EmailClient");
                Console.WriteLine("0 - Esci");
                Console.Write("Scelta: ");

                string scelta = Console.ReadLine();

                switch (scelta)
                {
                    case "1":
                        if (!mobileRegistrato)
                        {
                            agency.Subscribe(mobile);
                            mobileRegistrato = true;
                            Console.WriteLine("MobileApp registrata.");
                        }
                        else
                            Console.WriteLine("MobileApp già registrata.");
                        break;

                    case "2":
                        if (!emailRegistrato)
                        {
                            agency.Subscribe(email);
                            emailRegistrato = true;
                            Console.WriteLine("EmailClient registrato.");
                        }
                        else
                            Console.WriteLine("EmailClient già registrato.");
                        break;

                    case "3":
                        Console.Write("Inserisci la news: ");
                        string news = Console.ReadLine();
                        agency.News = news;
                        break;

                    case "4":
                        agency.Unsubscribe(mobile);
                        mobileRegistrato = false;
                        Console.WriteLine("MobileApp rimossa.");
                        break;

                    case "5":
                        agency.Unsubscribe(email);
                        emailRegistrato = false;
                        Console.WriteLine("EmailClient rimosso.");
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