using System;

class Program
{
    static void Main(string[] args)
    {
        // primo punto del codice
        Logger logger1 = Logger.GetIstanza();
        logger1.ScriviMessaggio("Applicazione avviata");

        Servizio servizio = new Servizio();
        servizio.EseguiOperazione();

        // secondo punto del codice
        Logger logger2 = Logger.GetIstanza();
        logger2.ScriviMessaggio("Operazione completata");

        // dimostrazione che è la stessa istanza
        Console.WriteLine(logger1 == logger2);
    }
}