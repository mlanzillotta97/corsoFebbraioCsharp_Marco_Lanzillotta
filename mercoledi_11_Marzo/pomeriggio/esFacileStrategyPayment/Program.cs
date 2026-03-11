using System;

class Program
{
    static void Main()
    {
        PaymentContext context = new PaymentContext();

        Console.WriteLine("=== Sistema di Pagamento ===");
        Console.WriteLine("1 - Carta di Credito");
        Console.WriteLine("2 - PayPal");
        Console.WriteLine("3 - Bitcoin");

        Console.Write("Scegli il metodo di pagamento: ");
        string scelta = Console.ReadLine();

        switch (scelta)
        {
            case "1":
                context.SetStrategy(new CreditCardPayment());
                break;

            case "2":
                context.SetStrategy(new PayPalPayment());
                break;

            case "3":
                context.SetStrategy(new BitcoinPayment());
                break;

            default:
                Console.WriteLine("Metodo non valido.");
                return;
        }

        context.Pay(100m);
    }
}