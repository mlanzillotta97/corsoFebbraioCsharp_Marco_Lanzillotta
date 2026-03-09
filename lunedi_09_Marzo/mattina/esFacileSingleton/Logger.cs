using System;

public class Logger
{
    // unica istanza
    private static Logger istanza;

    // costruttore privato
    private Logger()
    {
    }

    // metodo pubblico per ottenere l'istanza
    public static Logger GetIstanza()
    {
        if (istanza == null)
        {
            istanza = new Logger();
        }

        return istanza;
    }

    // metodo per scrivere il messaggio
    public void ScriviMessaggio(string messaggio)
    {
        Console.WriteLine($"{DateTime.Now} - {messaggio}");
    }
}