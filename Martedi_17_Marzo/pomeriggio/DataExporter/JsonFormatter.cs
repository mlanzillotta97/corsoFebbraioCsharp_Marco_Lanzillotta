public class JsonFormatter : IExportFormatter
{
    public string Format(Data data)
    {
        return $"{{ \"Nome\": \"{data.Nome}\", \"Valore\": {data.Valore} }}";
    }
}