using System;
using System.Security.Cryptography.X509Certificates;




//questo è un commento 
class Program
{
    static void Main(string[] args)
    {
        //es1
        /*
        int a = 10; int b = 15; 
        Console.WriteLine(a + b);

        //es2
        double originalPrice = 20;
        Console.WriteLine("Prezzo scontato: " + originalPrice*0.2);

        //es3 controllo di un numero positivo 
        float virgola = 10.7f;
        Console.WriteLine("Il numero è positivo? " + (virgola>0));
        */

        //es4
        /*
        Console.WriteLine("Dammi un numero intero");
        string n1 = Console.ReadLine();
        Console.WriteLine("Dammi un altro numero? ");
        string n2 = Console.ReadLine();

        int num1 = int.Parse(n1);
        float num2 = float.Parse(n2);

        Console.WriteLine($"Somma {num1 + num2}");
        */
        //es5
        Console.Write("Quanti anni hai?");
        string eta = Console.ReadLine();
        Console.Write("Qaunto sei alto?");
        string altezza = Console.ReadLine();
        
        int e = int.Parse(eta);
        float a = float.Parse(altezza);

        int risultato = (int)(e + a);
        Console.WriteLine("La somma di età e altezza inserita è: " + risultato);
        }
        
        //public readonly string Nome = "Franco";
        
}




