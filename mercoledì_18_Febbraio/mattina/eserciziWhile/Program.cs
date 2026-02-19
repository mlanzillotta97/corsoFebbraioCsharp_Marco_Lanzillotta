using System;

class Bancomat
{
    static void Main()
    {
        double saldo = 0.0;
        int scelta = 0;

        while (scelta != 4)
        {
            Console.WriteLine("\n--- SPORTELLO BANCOMAT ---");
            Console.WriteLine("1: Visualizza saldo");
            Console.WriteLine("2: Deposita denaro");
            Console.WriteLine("3: Preleva denaro");
            Console.WriteLine("4: Esci");
            Console.Write("Scegli un'opzione: ");

            scelta = Convert.ToInt32(Console.ReadLine());

            switch (scelta)
            {
                case 1:
                    Console.WriteLine($"Il tuo saldo attuale è: {saldo:F2} €");
                    break;

                case 2:
                    Console.Write("Inserisci l'importo da depositare: ");
                    double deposito = Convert.ToDouble(Console.ReadLine());

                    if (deposito > 0)
                    {
                        saldo += deposito;
                        Console.WriteLine($"Deposito effettuato. Nuovo saldo: {saldo:F2} €");
                    }
                    else
                    {
                        Console.WriteLine("Importo non valido.");
                    }
                    break;

                case 3:
                    Console.Write("Inserisci l'importo da prelevare: ");
                    double prelievo = Convert.ToDouble(Console.ReadLine());

                    if (prelievo > saldo)
                    {
                        Console.WriteLine("Errore: saldo insufficiente.");
                    }
                    else if (prelievo <= 0)
                    {
                        Console.WriteLine("Importo non valido.");
                    }
                    else
                    {
                        saldo -= prelievo;
                        Console.WriteLine($"Prelievo effettuato. Nuovo saldo: {saldo:F2} €");
                    }
                    break;

                case 4:
                    Console.WriteLine("Grazie per aver utilizzato il bancomat. Arrivederci!");
                    break;

                default:
                    Console.WriteLine("Opzione non valida. Riprova.");
                    break;
            }
        }
    }
}
