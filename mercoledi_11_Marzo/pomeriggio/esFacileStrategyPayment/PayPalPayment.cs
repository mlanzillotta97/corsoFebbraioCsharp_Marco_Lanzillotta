using System;

public class PayPalPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Pagamento di {amount}€ effettuato con PayPal.");
    }
}