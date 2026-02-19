using System;
class Program
{
    static void main(string[] args)
    {
        /*
        bool continua = true;
        while (continua)  //finché “continua” rimane true il codice viene ripetuto
        {
        Console.WriteLine("Ciclo in esecuzione");
        continua = bool.Parse(Console.ReadLine());
        }

        int continua2 = 0;
        while (continua2 < 10) //finché “continua” rimane true il codice viene ripetuto
        {
        Console.WriteLine("Ciclo in esecuzione");
        continua2 +=1;
        Console.WriteLine(continua2);
        }
        */

        //esercizio numero negativo 

        int numero = 0;
        int somma = 0;

        while (true)
        {
            Console.Write("Inserisci un numero intero positivo (numero negativo per terminare): ");
            numero = int.Parse(Console.ReadLine());

            if (numero < 0)
            {
                break; // esce dal ciclo
            }

            somma += numero; // aggiunge il numero alla somma
        }

        Console.WriteLine("La somma totale è: " + somma);
        Console.ReadLine();
        
    }
    
}
