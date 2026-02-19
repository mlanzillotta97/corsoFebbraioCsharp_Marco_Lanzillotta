class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Come ti chiami? ");
        string nome = Console.ReadLine();
        StampaSaluto(nome);

        VerificaPari(7);

        int risultato = CalcolaPotenza(2, 3);
        Console.WriteLine("Il risultato della potenza è: " + risultato);
    }

    //=============== METODO SALUTO ===============
    public static void StampaSaluto(string nome)
    {
        Console.WriteLine($"Ciao {nome}, bentornato!!!");
    }

    //=============== METODO PARI ===============

    static void VerificaPari(int numero)
    {
        if (numero % 2 == 0)
        {
            Console.WriteLine("Il numero " + numero + " è pari.");
        }
        else
        {
            Console.WriteLine("Il numero " + numero + " è dispari.");
        }
    }

    //=============== METODO CALCOLO POTENZA ===============

    static int CalcolaPotenza(int baseNum, int esponente)
    {
        int risultato = 1;

        for (int i = 1; i <= esponente; i++)
        {
            risultato *= baseNum;
        }

        return risultato;
    }
}

