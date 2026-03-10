using System;

namespace SistemaConfigurazione
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = ConfigurazioneSistema.Instance;

            bool continua = true;

            while (continua)
            {
                Console.WriteLine("\n===== SISTEMA DI CONFIGURAZIONE =====");
                Console.WriteLine("1 - Imposta configurazione");
                Console.WriteLine("2 - Leggi configurazione");
                Console.WriteLine("3 - Crea dispositivo");
                Console.WriteLine("4 - Mostra tutte le configurazioni");
                Console.WriteLine("5 - Verifica Singleton");
                Console.WriteLine("0 - Esci");
                Console.Write("Scelta: ");

                string scelta = Console.ReadLine();

                switch (scelta)
                {
                    case "1":
                        Console.Write("Inserisci chiave: ");
                        string chiave = Console.ReadLine();

                        Console.Write("Inserisci valore: ");
                        string valore = Console.ReadLine();

                        config.Imposta(chiave, valore);
                        Console.WriteLine("Configurazione salvata.");
                        break;

                    case "2":
                        Console.Write("Inserisci chiave da leggere: ");
                        string chiaveLettura = Console.ReadLine();

                        string risultato = config.Leggi(chiaveLettura);

                        if (risultato != null)
                            Console.WriteLine("Valore: " + risultato);
                        else
                            Console.WriteLine("Chiave non trovata.");
                        break;

                    case "3":
                        Console.Write("Tipo dispositivo (computer / stampante): ");
                        string tipo = Console.ReadLine();

                        IDispositivo dispositivo = DispositivoFactory.CreaDispositivo(tipo);

                        if (dispositivo != null)
                        {
                            dispositivo.Avvia();
                            dispositivo.MostraTipo();
                        }
                        else
                        {
                            Console.WriteLine("Tipo di dispositivo non valido.");
                        }
                        break;

                    case "4":
                        config.StampaTutte();
                        break;

                    case "5":
                        var configA = ConfigurazioneSistema.Instance;
                        var configB = ConfigurazioneSistema.Instance;

                        Console.WriteLine("Stessa istanza?");
                        Console.WriteLine(Object.ReferenceEquals(configA, configB));
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