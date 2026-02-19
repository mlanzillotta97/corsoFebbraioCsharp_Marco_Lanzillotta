using System;
using System.Security.Cryptography.X509Certificates;




//questo è un commento 
class Program
{
    static void Main(string[] args)
    {
    int a = 15;
    int b = 10;
    /* if (condizione == true){
    / esegui codice all'interno delle graffe
    }
    */
    if(a > b){ // (a<b) da come risultato True 
    Console.WriteLine($"{a} è maggiore di {b}");
    /* il blocco di  codice all'interno delle graffe verrà eseguito solo 
    se la condizione è vera, altrimenti verrà 
    saltato e ignorato durante l'esecuzione */
    }

    const int MAGGIORE_ETA = 18;

        // Input età
        Console.Write("Inserisci la tua età: ");
        string inputEta = Console.ReadLine();

        // Casting esplicito (conversione string -> int)
        int eta = int.Parse(inputEta);

        // Controllo con IF
        if (eta >= MAGGIORE_ETA)
        {
            Console.WriteLine("Sei maggiorenne.");
        }
        else
        {
            Console.WriteLine("Sei minorenne.");
        }

        // 2. PREZZO CON SCONTO DEL 10%
        // =====================================

        // Costante sconto
        const double SCONTO = 0.10;

        // Input prezzo
        Console.Write("Inserisci il prezzo del prodotto: ");
        string inputPrezzo = Console.ReadLine();

        // Conversione esplicita
        double prezzo = double.Parse(inputPrezzo);

        double prezzoFinale = prezzo;

        // Applicazione sconto solo se > 100
        if (prezzo > 100)
        {
            prezzoFinale = prezzo - (prezzo * SCONTO);
        }

        // Stampa con formattazione
        Console.WriteLine($"Prezzo finale: {prezzoFinale:F2} €");

        // 3. PROVA SUPERATA

    Console.WriteLine("Inserire il primo numero");
    double num1 = double.Parse(Console.ReadLine()!);
    Console.WriteLine("Inserire il secondo numero");
    double num2 = double.Parse(Console.ReadLine()!);
    Console.WriteLine("Inserire il terzo numero");
    double num3 = double.Parse(Console.ReadLine()!);

    double totale = num1 + num2 + num3; 

    if ((int)totale > 60) { Console.WriteLine("Hai superato la prova!");}
    if ((int)totale < 60) { Console.WriteLine("Prova fallita");} 

    Console.WriteLine;
    }    
}




