public class AlertService
{
    // Method Injection: il notifier viene passato direttamente al metodo
    public void SendAlert(string message, INotifier notifier)
    {
        notifier.Notify(message);
    }
}