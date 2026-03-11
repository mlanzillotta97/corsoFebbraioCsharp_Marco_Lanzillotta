using System;

public class CreditCardPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Pagamento di {amount}€ effettuato con Carta di Credito.");
    }
}