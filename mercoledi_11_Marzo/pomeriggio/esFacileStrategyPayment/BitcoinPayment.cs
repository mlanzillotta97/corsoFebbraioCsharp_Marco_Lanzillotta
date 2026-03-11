using System;

public class BitcoinPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Pagamento di {amount}€ effettuato con Bitcoin.");
    }
}