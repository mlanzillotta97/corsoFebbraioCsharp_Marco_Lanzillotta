using System;

class Program
{
    static void Main()
    {

        // Aggiungi observer
        SistemaNotifiche.GetInstance().AggiungiObserver(new ConsoleObserver());

        Calcolatrice calcolatrice = new Calcolatrice();

        Console.WriteLine("=== Calcolatrice Strategy ===");
        Console.Write("Inserisci il primo numero: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Inserisci il secondo numero: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nScegli l'operazione:");
        Console.WriteLine("1 - Somma");
        Console.WriteLine("2 - Sottrazione");
        Console.WriteLine("3 - Moltiplicazione");
        Console.WriteLine("4 - Divisione");
        Console.Write("Scelta: ");
        string scelta = Console.ReadLine();

        switch (scelta)
        {
            case "1":
                calcolatrice.ImpostaStrategia(new SommaStrategia());
                break;
            case "2":
                calcolatrice.ImpostaStrategia(new SottrazioneStrategia());
                break;
            case "3":
                calcolatrice.ImpostaStrategia(new MoltiplicazioneStrategia());
                break;
            case "4":
                calcolatrice.ImpostaStrategia(new DivisioneStrategia());
                break;
            default:
                Console.WriteLine("Scelta non valida.");
                return;
        }

        try
        {
            double risultato = calcolatrice.EseguiOperazione(a, b);
            Console.WriteLine($"\nRisultato: {risultato}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Errore: {ex.Message}");
        }
    }
}