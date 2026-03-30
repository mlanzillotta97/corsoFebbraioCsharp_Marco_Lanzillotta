public class DataExporter
{
    // Method Injection: formatter passato al metodo
    public void Export(Data data, IExportFormatter formatter)
    {
        string risultato = formatter.Format(data);
        Console.WriteLine("Dati esportati:");
        Console.WriteLine(risultato);
    }
}