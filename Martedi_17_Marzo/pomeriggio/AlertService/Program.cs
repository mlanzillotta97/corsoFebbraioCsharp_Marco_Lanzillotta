class Program
{
    static void Main()
    {
        var alertService = new AlertService();
        var smsNotifier = new SmsNotifier();

        alertService.SendAlert("Attenzione! Temperatura troppo alta.", smsNotifier);
    }
}