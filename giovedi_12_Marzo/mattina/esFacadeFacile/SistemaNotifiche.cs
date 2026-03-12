using System.Collections.Generic;

public class SistemaNotifiche
{
    private List<IObserver> observers = new List<IObserver>();

    public void AggiungiObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void Notifica(string messaggio)
    {
        foreach (var obs in observers)
        {
            obs.Update(messaggio);
        }
    }
}