using System;
/*
class Program
{
    static void Main()
    {
        int[] voti = new int[5];

        for (int i = 0; i < voti.Length; i++)
        {
            Console.Write($"Inserisci il voto {i + 1}: ")
            voti[i] = int.Parse(Console.ReadLine());
        }

        int somma = 0; 
        for (int i = 0; i < voti.Length; i ++)
        {
            somma += voti[i];
        }

        float media = (float)somma / voti.Length;
        Console.WriteLine($"La media dei voti è: {media}");
    }
}
*/

class ProgramsForEach
{
    static void Main()
    {
        /*
        string parola = "CSharp";

        Console.WriteLine("Caratteri della stringa: ");
        foreach (char carattere in parola)
        {
            Console.WriteLine(carattere);
        }
        

        int[] numeri = { 10, 20, 30, 40, 50 };

        Console.WriteLine("Elementi dell'array:");

        foreach (int numero in numeri)
        {
            Console.WriteLine(numero);
        }
        

        string continua;

        do
        {
            Console.WriteLine("\nScegli il tipo di array:");
            Console.WriteLine("1 - Stringhe");
            Console.WriteLine("2 - Interi");
            Console.Write("Scelta: ");

            int scelta = Convert.ToInt32(Console.ReadLine());

            Console.Write("Quanto deve essere lungo l'array? ");
            int lunghezza = Convert.ToInt32(Console.ReadLine());

            if (lunghezza <= 0)
            {
                Console.WriteLine("Lunghezza non valida.");
            }
            else
            {
                if (scelta == 1)
                {
                    string[] arrayStringhe = new string[lunghezza];

                    for (int i = 0; i < lunghezza; i++)
                    {
                        Console.Write($"Inserisci la stringa {i + 1}: ");
                        arrayStringhe[i] = Console.ReadLine();
                    }

                    Console.WriteLine("\nContenuto dell'array:");
                    foreach (string elemento in arrayStringhe)
                    {
                        Console.WriteLine(elemento);
                    }
                }
                else if (scelta == 2)
                {
                    int[] arrayInteri = new int[lunghezza];

                    for (int i = 0; i < lunghezza; i++)
                    {
                        Console.Write($"Inserisci il numero {i + 1}: ");
                        arrayInteri[i] = Convert.ToInt32(Console.ReadLine());
                    }

                    Console.WriteLine("\nContenuto dell'array:");
                    foreach (int elemento in arrayInteri)
                    {
                        Console.WriteLine(elemento);
                    }
                }
                else
                {
                    Console.WriteLine("Scelta non valida.");
                }
            }

            Console.Write("\nVuoi ripetere il programma? (s/n): ");
            continua = Console.ReadLine().ToLower();

        } while (continua == "s");

        Console.WriteLine("Programma terminato.");

        */

        //esercizio conteggiocifre

        Console.Write("Inserisci una frase: ");
        string frase = Console.ReadLine();

        int conteggioCifre = 0;

        foreach (char carattere in frase)
        {
            if (char.IsDigit(carattere))
            {
                conteggioCifre++;
            }
        }

        Console.WriteLine("Numero di cifre presenti: " + conteggioCifre);

        //esercizio stampa nuova stringa 

        Console.Write("Inserisci una frase: ");
        string parole = Console.ReadLine();

        string nuovaFrase = "";

        foreach (char carattere in parole)
        {
            if (carattere != ' ')
            {
                nuovaFrase += carattere;
            }
        }

        Console.WriteLine("Frase senza spazi:");
        Console.WriteLine(nuovaFrase); 

        //esercizio che riceve stringa e restituisce numero vocali contenute 

                Console.Write("Inserisci una frase: ");
        string testo = Console.ReadLine();

        int numeroVocali = ContaVocali(testo);

        Console.WriteLine("Numero di vocali: " + numeroVocali);
    }

    static int ContaVocali(string input)
    {
        int conteggio = 0;
        string vocali = "aeiou";

        foreach (char c in input)
        {
            char carattere = char.ToLower(c);

            if (vocali.Contains(carattere))
            {
                conteggio++;
            }
        }

        return conteggio;
    }
}
/*
class esercizioQuattro
{
    static void Main()
    {
        Console.Write("Inserisci una password: ");
        string password = Console.ReadLine();

        if (PasswordValida(password))
        {
            Console.WriteLine("Password valida.");
        }
        else
        {
            Console.WriteLine("Password non valida.");
        }
    }

    static bool PasswordValida(string password)
    {
        // Controllo lunghezza minima
        if (password.Length < 8)
            return false;

        // Non deve iniziare o finire con spazi
        if (password.StartsWith(" ") || password.EndsWith(" "))
            return false;

        bool haMaiuscola = false;
        bool haNumero = false;

        foreach (char c in password)
        {
            if (char.IsUpper(c))
                haMaiuscola = true;

            if (char.IsDigit(c))
                haNumero = true;
        }

        return haMaiuscola && haNumero;
    }
}
*/