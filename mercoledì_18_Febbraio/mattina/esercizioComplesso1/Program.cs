using System;

class Program
{
    static void Main()
    {
        string nomeRegistrato = "";
        string passwordRegistrata = "";
        bool utenteRegistrato = false;
        int scelta = 0;

        do
        {
            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine("1. Registrati alla piattaforma");
            Console.WriteLine("2. Effettua Login");
            Console.WriteLine("3. Esci dalla piattaforma");
            Console.Write("Scegli un'opzione: ");

            scelta = Convert.ToInt32(Console.ReadLine());

            switch (scelta)
            {
                case 1:
                    Console.Write("Inserisci nome utente: ");
                    nomeRegistrato = Console.ReadLine();

                    Console.Write("Inserisci password: ");
                    passwordRegistrata = Console.ReadLine();

                    utenteRegistrato = true;
                    Console.WriteLine("Registrazione completata!");
                    break;

                case 2:
                    if (!utenteRegistrato)
                    {
                        Console.WriteLine("Nessun utente registrato. Registrati prima.");
                        break;
                    }

                    Console.Write("Inserisci nome utente: ");
                    string nomeLogin = Console.ReadLine();

                    Console.Write("Inserisci password: ");
                    string passwordLogin = Console.ReadLine();

                    if (nomeLogin == nomeRegistrato && passwordLogin == passwordRegistrata)
                    {
                        Console.WriteLine("Accesso effettuato!");

                        Console.Write("Inserisci un numero per il conto alla rovescia: ");
                        int numero = Convert.ToInt32(Console.ReadLine());

                        for (int i = numero; i >= 0; i--)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Credenziali errate.");
                    }
                    break;

                case 3:
                    Console.WriteLine("Uscita dal programma...");
                    break;

                default:
                    Console.WriteLine("Scelta non valida.");
                    break;
            }

        } while (scelta != 3);
    }
}
