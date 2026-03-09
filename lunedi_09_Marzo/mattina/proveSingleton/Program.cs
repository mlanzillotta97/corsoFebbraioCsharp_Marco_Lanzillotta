using System;

public sealed class Singleton
{
    private static Singleton _instance;
    private static readonly object _lock = new object();

    private Singleton()
    {
        // inizializzazione
    }

    public static Singleton Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                }
            }
            return _instance;
        }
    }

    public void DoSomething()
    {
        Console.WriteLine("Metodo DoSomething chiamato sull'istanza Singleton.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        var istanza1 = Singleton.Instance;
        istanza1.DoSomething();

        // prova a richiederla di nuovo
        var istanza2 = Singleton.Instance;

        Console.WriteLine(istanza1 == istanza2); // true → stessa istanza
    }
}