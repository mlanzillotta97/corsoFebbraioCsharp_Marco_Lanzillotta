using System;

public class PaymentContext
{
    private IPaymentStrategy strategy;

    public void SetStrategy(IPaymentStrategy newStrategy)
    {
        strategy = newStrategy;
    }

    public void Pay(decimal amount)
    {
        if (strategy == null)
        {
            Console.WriteLine("Nessun metodo di pagamento selezionato.");
            return;
        }

        strategy.Pay(amount);
    }
}