using System;

class Program
{
    public static void Main()
    {
        /*
        bool continua = true;
        do
        {
            Console.WriteLine("Ciclo in esecuzione");
        }
        while (continua);
        

        // es passw utente 1

        int passwordCorretta = 1234;   // Password impostata
        int tentativi = 0;
        bool accessoConsentito = false;

        while (tentativi < 3 && !accessoConsentito)
        {
            Console.Write("Inserisci la password numerica: ");
            int passwordInserita = Convert.ToInt32(Console.ReadLine());

            if (passwordInserita == passwordCorretta)
            {
                Console.WriteLine("Accesso consentito!");
                accessoConsentito = true;
            }
            else
            {
                tentativi++;
                Console.WriteLine("Password errata.");

                if (tentativi < 3)
                {
                    Console.WriteLine($"Tentativi rimasti: {3 - tentativi}");
                }
            }
        }

        if (!accessoConsentito)
        {
            Console.WriteLine("Tentativi esauriti. Accesso bloccato.");
        }

        // es num interi utente 2 

        int numero;
        int somma = 0;
        int conteggio = 0;

        Console.WriteLine("Inserisci numeri interi (0 per terminare):");

        do
        {
            Console.Write("Numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero != 0)
            {
                somma += numero;
                conteggio++;
            }

        } while (numero != 0);

        Console.WriteLine("\n--- RISULTATO ---");
        Console.WriteLine("Somma totale: " + somma);
        Console.WriteLine("Numeri inseriti: " + conteggio);


        // es calcolatrice con più operazioni matematiche utente 3 

        string continua;

        do
        {
            Console.Write("Inserisci il primo numero: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Inserisci l'operatore (+, -, *, /): ");
            char operatore = Convert.ToChar(Console.ReadLine());

            Console.Write("Inserisci il secondo numero: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double risultato = 0;
            bool operazioneValida = true;

            switch (operatore)
            {
                case '+':
                    risultato = num1 + num2;
                    break;

                case '-':
                    risultato = num1 - num2;
                    break;

                case '*':
                    risultato = num1 * num2;
                    break;

                case '/':
                    if (num2 != 0)
                        risultato = num1 / num2;
                    else
                    {
                        Console.WriteLine("Errore: divisione per zero.");
                        operazioneValida = false;
                    }
                    break;

                default:
                    Console.WriteLine("Operatore non valido.");
                    operazioneValida = false;
                    break;
            }

            if (operazioneValida)
            {
                Console.WriteLine($"Risultato: {risultato}");
            }

            Console.Write("\nVuoi eseguire un'altra operazione? (s/n): ");
            continua = Console.ReadLine().ToLower();

        } while (continua == "s");

        Console.WriteLine("Calcolatrice terminata. Arrivederci!");
        */

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }

        //num int con tabellina 

        Console.Write("Inserisci un numero intero: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"\nTabellina del {numero}:");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numero} x {i} = {numero * i}");
        }

        //num int da inserire 

        Console.Write("Quanti numeri interi vuoi inserire? ");
        int quanti = Convert.ToInt32(Console.ReadLine());

        int somma = 0;

        for (int i = 1; i <= quanti; i++)
        {
            Console.Write($"Inserisci il numero {i}: ");
            int numeri = Convert.ToInt32(Console.ReadLine());
            somma += numeri;
        }

        if (quanti > 0)
        {
            double media = (double)somma / quanti;
            Console.WriteLine($"\nLa media è: {media}");
        }
        else
        {
            Console.WriteLine("Non hai inserito numeri validi per calcolare la media.");
        }

        //num positivo con fattoriale 

        Console.Write("Inserisci un numero intero positivo: ");
        int numeretti = Convert.ToInt32(Console.ReadLine());

        if (numeretti < 0)
        {
            Console.WriteLine("Errore: devi inserire un numero intero positivo.");
        }
        else
        {
            int fattoriale = 1;

            for (int i = 1; i <= numeretti; i++)
            {
                fattoriale *= i;
            }

            Console.WriteLine($"{numeretti}! = {fattoriale}");
        }

    }
}




