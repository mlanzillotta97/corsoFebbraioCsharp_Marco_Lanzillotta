public class Printer
{
    // Setter Injection (proprietà pubblica)
    public ILogger? Logger { get; set; }

    public void Print()
    {
        if (Logger != null)
            Logger.Log("Sto stampando un documento...");
        else
            Console.WriteLine("Logger non impostato!");
    }
}