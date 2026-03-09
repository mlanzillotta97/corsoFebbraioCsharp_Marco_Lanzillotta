using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quale veicolo vuoi creare?");
        Console.WriteLine("auto - moto - camion");
        Console.Write("Scelta: ");

        string tipo = Console.ReadLine();

        IVeicolo veicolo = VeicoloFactory.CreaVeicolo(tipo);

        if (veicolo != null)
        {
            veicolo.Avvia();
            veicolo.MostraTipo();
        }
    }
}