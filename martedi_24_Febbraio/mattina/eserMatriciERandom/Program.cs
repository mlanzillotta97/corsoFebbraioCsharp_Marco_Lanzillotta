using System;

class Program
{
    static void Main()
    {
        Esercizio1();
        Esercizio2();
        Esercizio3();
        Esercizio4();
        Esercizio5();
        Esercizio6();
    }

    static void Esercizio1()
    {
        Random random = new Random();

        // Genera un numero casuale tra 1 e 10
        int numeroSegreto = random.Next(1, 11); // 11 perché il limite superiore è escluso

        Console.Write("Indovina il numero (tra 1 e 10): ");
        int tentativo = int.Parse(Console.ReadLine());

        if (tentativo == numeroSegreto)
        {
            Console.WriteLine("Complimenti! Hai indovinato 🎉");
        }
        else
        {
            Console.WriteLine("Mi dispiace! Il numero era " + numeroSegreto);
        }
    }
    

    
        static void Esercizio2()
    {
        Random random = new Random();

        // Simula il lancio di due dadi (1-6)
        int dado1 = random.Next(1, 7);
        int dado2 = random.Next(1, 7);

        int somma = dado1 + dado2;

        Console.WriteLine("Risultato del primo dado: " + dado1);
        Console.WriteLine("Risultato del secondo dado: " + dado2);
        Console.WriteLine("Somma totale: " + somma);
    }
    

        static void Esercizio3()
    {
        Random random = new Random();

        const int minTemp = -5;   // temperatura minima possibile
        const int maxTemp = 35;   // temperatura massima possibile

        Console.Write("Quanti giorni vuoi simulare? ");
        int giorni = int.Parse(Console.ReadLine());

        int[] temperature = new int[giorni];

        int somma = 0;
        int tempMinima = int.MaxValue;
        int tempMassima = int.MinValue;

        // Generazione temperature
        for (int i = 0; i < giorni; i++)
        {
            temperature[i] = random.Next(minTemp, maxTemp + 1);
            somma += temperature[i];

            if (temperature[i] < tempMinima)
                tempMinima = temperature[i];

            if (temperature[i] > tempMassima)
                tempMassima = temperature[i];
        }

        // Calcolo media
        double media = (double)somma / giorni;

        // Output risultati
        Console.WriteLine("\nTemperature generate:");
        for (int i = 0; i < giorni; i++)
        {
            Console.WriteLine("Giorno " + (i + 1) + ": " + temperature[i] + "°C");
        }

        Console.WriteLine("\nTemperatura minima: " + tempMinima + "°C");
        Console.WriteLine("Temperatura massima: " + tempMassima + "°C");
        Console.WriteLine("Temperatura media: " + media.ToString("F2") + "°C");
    }

    //----------ESERCIZI MATRICE----------//

        static void Esercizio4()
    {
        Console.Write("Inserisci numero di righe: ");
        int righe = int.Parse(Console.ReadLine());

        Console.Write("Inserisci numero di colonne: ");
        int colonne = int.Parse(Console.ReadLine());

        int[,] matrice = new int[righe, colonne];

        // Inserimento valori
        for (int i = 0; i < righe; i++)
        {
            for (int j = 0; j < colonne; j++)
            {
                Console.Write($"Inserisci valore per [{i},{j}]: ");
                matrice[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int sommaTotale = 0;

        Console.WriteLine("\nSomma delle righe:");
        for (int i = 0; i < righe; i++)
        {
            int sommaRiga = 0;

            for (int j = 0; j < colonne; j++)
            {
                sommaRiga += matrice[i, j];
            }

            Console.WriteLine($"Riga {i}: {sommaRiga}");
            sommaTotale += sommaRiga;
        }

        Console.WriteLine("\nSomma delle colonne:");
        for (int j = 0; j < colonne; j++)
        {
            int sommaColonna = 0;

            for (int i = 0; i < righe; i++)
            {
                sommaColonna += matrice[i, j];
            }

            Console.WriteLine($"Colonna {j}: {sommaColonna}");
        }

        Console.WriteLine($"\nSomma totale degli elementi: {sommaTotale}");
    }

        static void Esercizio5()
    {
        const int dimensione = 4;
        Random random = new Random();

        int[,] matrice1 = new int[dimensione, dimensione];
        int[,] matrice2 = new int[dimensione, dimensione];

        int[] sommeRighe1 = new int[dimensione];
        int[] sommeRighe2 = new int[dimensione];

        // Generazione matrici
        for (int i = 0; i < dimensione; i++)
        {
            for (int j = 0; j < dimensione; j++)
            {
                matrice1[i, j] = random.Next(1, 51);
                matrice2[i, j] = random.Next(1, 51);
            }
        }

        Console.WriteLine("MATRICE 1:");
        StampaMatrice(matrice1, sommeRighe1);

        Console.WriteLine("\nMATRICE 2:");
        StampaMatrice(matrice2, sommeRighe2);

        // Confronto righe
        int vittorie1 = 0;
        int vittorie2 = 0;

        for (int i = 0; i < dimensione; i++)
        {
            if (sommeRighe1[i] > sommeRighe2[i])
                vittorie1++;
            else if (sommeRighe2[i] > sommeRighe1[i])
                vittorie2++;
        }

        Console.WriteLine("\nRISULTATO FINALE:");

        if (vittorie1 > vittorie2)
            Console.WriteLine("La Matrice 1 vince con " + vittorie1 + " righe vincenti!");
        else if (vittorie2 > vittorie1)
            Console.WriteLine("La Matrice 2 vince con " + vittorie2 + " righe vincenti!");
        else
            Console.WriteLine("Pareggio!");
    }

    static void StampaMatrice(int[,] matrice, int[] sommeRighe)
    {
        int dimensione = matrice.GetLength(0);

        for (int i = 0; i < dimensione; i++)
        {
            int somma = 0;

            for (int j = 0; j < dimensione; j++)
            {
                Console.Write(matrice[i, j].ToString().PadLeft(4));
                somma += matrice[i, j];
            }

            sommeRighe[i] = somma;
            Console.Write("  | Somma riga: " + somma);
            Console.WriteLine();
        }
    }


    
        static void Esercizio6()
    {
        const int dimensione = 5;
        Random random = new Random();

        int[,] matrice = new int[dimensione, dimensione];

        // Generazione matrice
        for (int i = 0; i < dimensione; i++)
        {
            for (int j = 0; j < dimensione; j++)
            {
                matrice[i, j] = random.Next(1, 21);
            }
        }

        int sommaPrincipale = 0;
        int sommaSecondaria = 0;

        Console.WriteLine("MATRICE 5x5:\n");

        for (int i = 0; i < dimensione; i++)
        {
            for (int j = 0; j < dimensione; j++)
            {
                Console.Write(matrice[i, j].ToString().PadLeft(4));

                // Diagonale principale (i == j)
                if (i == j)
                    sommaPrincipale += matrice[i, j];

                // Diagonale secondaria (i + j == dimensione - 1)
                if (i + j == dimensione - 1)
                    sommaSecondaria += matrice[i, j];
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nSomma diagonale principale: " + sommaPrincipale);
        Console.WriteLine("Somma diagonale secondaria: " + sommaSecondaria);

        if (sommaPrincipale > sommaSecondaria)
            Console.WriteLine("La diagonale principale è maggiore.");
        else if (sommaSecondaria > sommaPrincipale)
            Console.WriteLine("La diagonale secondaria è maggiore.");
        else
            Console.WriteLine("Le due diagonali sono uguali.");
    }
}
