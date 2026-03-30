class Program
{
    static void Main()
    {
        var printer = new Printer();

        // Iniezione tramite proprietà
        printer.Logger = new ConsoleLogger();

        printer.Print();
    }
}