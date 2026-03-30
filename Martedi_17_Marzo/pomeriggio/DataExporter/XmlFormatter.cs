public class XmlFormatter : IExportFormatter
{
    public string Format(Data data)
    {
        return $"<Data><Nome>{data.Nome}</Nome><Valore>{data.Valore}</Valore></Data>";
    }
}