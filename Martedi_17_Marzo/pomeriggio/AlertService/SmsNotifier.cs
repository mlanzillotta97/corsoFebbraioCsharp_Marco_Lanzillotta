public class SmsNotifier : INotifier
{
    public void Notify(string message)
    {
        Console.WriteLine($"SMS inviato: {message}");
    }
}