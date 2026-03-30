class Program
{
    static void Main()
    {
        var data = new Data { Nome = "Prodotto1", Valore = 100 };

        var exporter = new DataExporter();

        // 🔹 JSON
        var jsonFormatter = new JsonFormatter();
        exporter.Export(data, jsonFormatter);

        Console.WriteLine();

        // 🔹 XML
        var xmlFormatter = new XmlFormatter();
        exporter.Export(data, xmlFormatter);
    }
}