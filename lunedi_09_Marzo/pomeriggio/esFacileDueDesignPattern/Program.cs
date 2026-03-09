using System;

class Program
{
    static void Main(string[] args)
    {
        int scelta;

        do
        {
            Console.WriteLine("\n=== MENU VEICOLI ===");
            Console.WriteLine("1 - Crea veicolo");
            Console.WriteLine("2 - Stampa tutti i veicoli registrati");
            Console.WriteLine("0 - Esci");
            Console.Write("Scelta: ");

            scelta = int.Parse(Console.ReadLine());

            switch (scelta)
            {
                case 1:

                    Console.WriteLine("Che veicolo vuoi creare?");
                    Console.WriteLine("auto - moto - camion");
                    Console.Write("Scelta: ");

                    string tipo = Console.ReadLine();

                    IVeicolo veicolo = VeicoloFactory.CreaVeicolo(tipo);

                    if (veicolo != null)
                    {
                        veicolo.Avvia();
                        veicolo.MostraTipo();

                        RegistroVeicoli.Instance.Registra(veicolo);
                    }

                    break;

                case 2:

                    RegistroVeicoli.Instance.StampaTutti();

                    break;

                case 0:

                    Console.WriteLine("Uscita dal programma");

                    break;

                default:

                    Console.WriteLine("Scelta non valida");

                    break;
            }

        } while (scelta != 0);
    }
}