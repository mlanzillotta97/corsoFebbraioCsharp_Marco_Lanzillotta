using System;

public class PagamentoCarta : IPagamento
{
    public string Circuito { get; set; }

    public PagamentoCarta(string circuito)
    {
        Circuito = circuito;
    }

    public void EseguiPagamento(decimal importo)
    {
        Console.WriteLine("Pagamento di " + importo + " euro con carta (Circuito: " + Circuito + ")");
    }

    public void MostraMetodo()
    {
        Console.WriteLine("Metodo: Carta di credito");
    }
}