using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<IPagamento> pagamenti = new List<IPagamento>();

        pagamenti.Add(new PagamentoCarta("Visa"));
        pagamenti.Add(new PagamentoContanti());
        pagamenti.Add(new PagamentoPayPal("utente@email.com"));

        Console.WriteLine("=== SISTEMA DI PAGAMENTO ===");
        Console.WriteLine("1 - Mostra ed esegui tutti i pagamenti");
        Console.WriteLine("0 - Esci");
        Console.Write("Scelta: ");

        int scelta = int.Parse(Console.ReadLine());

        if (scelta == 1)
        {
            foreach (IPagamento pagamento in pagamenti)
            {
                pagamento.MostraMetodo();
                pagamento.EseguiPagamento(50);
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Programma terminato.");
        }
    }
}