using System;
using System.Security.Cryptography.X509Certificates;




//questo è un commento 
class Program
{
    static void Main(string[] args)
    {
        /*
        int a = 10;
        int b = 15;

        if(a > b)
        {
            Console.WriteLine($"{a} è maggiore di {b}");
        }
        else
        {
            Console.WriteLine($"{a} è minore di {b}");
        }

        //esercizio numero intero 

        Console.Write("Inserisci un numero intero: ");
        string inputNumero = Console.ReadLine();

        // Conversione esplicita string -> int
        int numero = int.Parse(inputNumero);

        // Uso del modulo %
        if (numero % 2 == 0)
        {
            Console.WriteLine("Il numero è pari");
        }
        else
        {
            Console.WriteLine("Il numero è dispari");
        }

        //esercizio password

        const int password = 1234;

        Console.Write("Inserisci la password numerica: ");
        string inputPassword = Console.ReadLine();

        // Conversione esplicita
        int passwordInserita = int.Parse(inputPassword);

        // Controllo con if-else
        if (passwordInserita == password)
        {
            Console.WriteLine("Accesso consentito.");
        }
        else
        {
            Console.WriteLine("Accesso negato.");
        }
        */

        //Calcolatrice con switch e case 
        /*
        double num1 = 0; double num2 = 0;
            Console.WriteLine("Calcolatrice C# Console\r");
            Console.WriteLine("------------------------\n");

            Console.WriteLine("Inserisci il primo numero e premi Invio:");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Inserisci il secondo numero e premi Invio:");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Scegli un operatore:");
            Console.WriteLine("\ta - Addizione (+)");
            Console.WriteLine("\ts - Sottrazione (-)");
            Console.WriteLine("\tm - Moltiplicazione (*)");
            Console.WriteLine("\td - Divisione (/)");
            Console.Write("La tua opzione? ");

            string op = Console.ReadLine();

            switch (op)
            {
                case "a":
                    Console.WriteLine($"Risultato: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Risultato: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Risultato: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    if (num2 != 0)
                        Console.WriteLine($"Risultato: {num1} / {num2} = " + (num1 / num2));
                    else
                        Console.WriteLine("Errore: Divisione per zero!");
                    break;
            }
            Console.Write("Premi un tasto per chiudere...");
            Console.ReadKey();
        /*
        /*--------------------------*/
        //else if 
        /*
        int voto = 28;

        if(voto >= 30)
        {
            Console.WriteLine("Eccellente");
        }
        else if (eta >= 18)
        {
            Console.WriteLine("Insufficiente");
        }

        //if else if 

        int eta = 18;

        if(eta >= 18)
        {
            Console.WriteLine("Maggiorenne");
        }
        else if (eta >= 13)
        {
            Console.WriteLine("Adolescente");
        }
        else
        {
            Console.WriteLine("Bambino");
        }


        //esercizi if-else
        //voto
        /*
        Console.Write("Inserisci il voto: ");
        int voto = int.Parse(Console.ReadLine());

        if(voto <= 4)
        {
            Console.WriteLine("Insufficiente");
        }
        else if (voto <= 6)
        {
            Console.WriteLine("Sufficiente");
        }
        else if (voto <= 8)
        {
            Console.WriteLine("Buono");
        }
        else 
        {
            Console.WriteLine("Ottimo");
        }
        */

        string giorno = "lunedì";

        switch (giorno)
        {
            case "lunedì":
                Console.WriteLine("Inizio settimana");
                break;
            case "venerdì":
                Console.WriteLine("Quasi weekend");
                break;
            default:
                Console.WriteLine("Altro giorno");
                break;
        }

        //esercizio settimana 

        Console.Write("Inserisci un numero da 1 a 7: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero == 1)
        {
            Console.WriteLine("Lunedì");
        }
        else if (numero == 2)
        {
            Console.WriteLine("Martedì");
        }
        else if (numero == 3)
        {
            Console.WriteLine("Mercoledì");
        }
        else if (numero == 4)
        {
            Console.WriteLine("Giovedì");
        }
        else if (numero == 5)
        {
            Console.WriteLine("Venerdì");
        }
        else if (numero == 6)
        {
            Console.WriteLine("Sabato");
        }
        else if (numero == 7)
        {
            Console.WriteLine("Domenica");
        }
        else
        {
            Console.WriteLine("Numero non valido!");
        }

        Console.ReadLine();
        //body mass index BMI 

        //esercizio misure geometriche 

        Console.Write("Quale figura vuoi calcolare? (quadrato, cerchio, triangolo): ");
        string figura = Console.ReadLine();

        if (figura == "quadrato")
        {
            Console.Write("Inserisci il lato: ");
            double lato = double.Parse(Console.ReadLine());

            double area = lato * lato;
            Console.WriteLine("L'area del quadrato è: " + area);
        }
        else if (figura == "cerchio")
        {
            Console.Write("Inserisci il raggio: ");
            double raggio = double.Parse(Console.ReadLine());

            double area = Math.PI * raggio * raggio;
            Console.WriteLine("L'area del cerchio è: " + area);
        }
        else if (figura == "triangolo")
        {
            Console.Write("Inserisci la base: ");
            double baseTri = double.Parse(Console.ReadLine());

            Console.Write("Inserisci l'altezza: ");
            double altezza = double.Parse(Console.ReadLine());

            double area = (baseTri * altezza) / 2;
            Console.WriteLine("L'area del triangolo è: " + area);
        }
        else
        {
            Console.WriteLine("Figura non valida!");
        }

        Console.ReadLine();
    }

        
        
}




