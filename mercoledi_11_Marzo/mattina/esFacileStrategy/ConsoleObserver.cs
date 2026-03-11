using System;

public class ConsoleObserver : IObserver
{
    public void Aggiorna(string messaggio)
    {
        Console.WriteLine($"[Notifica] {messaggio}");
    }
}