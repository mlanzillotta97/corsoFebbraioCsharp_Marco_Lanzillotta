using System.Collections.Generic;

public class SistemaNotifiche
{
    private static SistemaNotifiche? instance;
    private readonly List<IObserver> observers = new List<IObserver>();

    private SistemaNotifiche() { }

    public static SistemaNotifiche GetInstance()
    {
        if (instance == null)
            instance = new SistemaNotifiche();
        return instance;
    }

    public void AggiungiObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void Notifica(string messaggio)
    {
        foreach (var obs in observers)
            obs.Aggiorna(messaggio);
    }
}