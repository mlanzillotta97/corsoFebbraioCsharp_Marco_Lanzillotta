using System;

class Program
{
    static void Main(string[] args)
    {
        SistemaNotifiche notifiche = new SistemaNotifiche();

        Utente utente1 = new Utente("Marco");
        Utente utente2 = new Utente("Luca");

        notifiche.AggiungiObserver(utente1);
        notifiche.AggiungiObserver(utente2);

        GamingSetupFacade gaming = new GamingSetupFacade(notifiche);

        gaming.AvviaPostazione();

        Console.WriteLine();

        gaming.SpegniPostazione();
    }
}