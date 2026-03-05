using System;

public class PagamentoPayPal : IPagamento
{
    public string EmailUtente { get; set; }

    public PagamentoPayPal(string email)
    {
        EmailUtente = email;
    }

    public void EseguiPagamento(decimal importo)
    {
        Console.WriteLine("Pagamento di " + importo + " euro tramite PayPal da: " + EmailUtente);
    }

    public void MostraMetodo()
    {
        Console.WriteLine("Metodo: PayPal");
    }
}