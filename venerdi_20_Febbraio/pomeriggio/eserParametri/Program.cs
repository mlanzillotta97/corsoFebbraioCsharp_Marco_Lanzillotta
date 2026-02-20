using System;

class Program
{
    public static void Main(string[] args)
    {
        //es1
        int valore = 5; 
        Raddoppia(ref valore);

        //es2
        int giorno = 35; 
        int mese = 12; 
        int anno = 2024; 
        Console.WriteLine($"Prima: {giorno}/{mese}/{anno}"); 
        AggiustaData(ref giorno, ref mese, ref anno); 
        Console.WriteLine($"Dopo: {giorno}/{mese}/{anno}"); 
        
        //es3
        int a = 17; 
        int b = 5; 
        Dividi(a, b, out int q, out int r); 
        Console.WriteLine("Quoziente: " + q); 
        Console.WriteLine("Resto: " + r); 

        //es4 
        string frase = "ciao come stai"; 
        AnalizzaParola(frase, out int v, out int c, out int s); 
        Console.WriteLine("Vocali: " + v); 
        Console.WriteLine("Consonanti: " + c); 
        Console.WriteLine("Spazi: " + s);

        //es5
        int punteggioCorrente = 0;
        int punteggioTotale = 0;
        float media;
        // Turno 1
        AggiornaPunteggio(ref punteggioCorrente, 10, ref punteggioTotale, out media);
        // Turno 2
        AggiornaPunteggio(ref punteggioCorrente, 20, ref punteggioTotale, out media);
        // Turno 3
        AggiornaPunteggio(ref punteggioCorrente, 15, ref punteggioTotale, out media);
        Console.WriteLine("Media finale sui 3 turni: " + media);
        
        //es6 
        int voto1 = 5;
        int voto2 = 7;
        int bonus = 2;

        bool promosso = ElaboraStudente(ref voto1, ref voto2, bonus, out double mediaFinale);

        Console.WriteLine($"Voto 1: {voto1}");
        Console.WriteLine($"Voto 2: {voto2}");
        Console.WriteLine($"Media: {mediaFinale}");

        if (promosso)
        Console.WriteLine("Studente promosso");
        else
        Console.WriteLine("Studente bocciato");



    }

        // =====================================
        // 1) Esercizio raddoppia 
        // =====================================


    static void Raddoppia(ref int numero) 
    { 
        Console.WriteLine("Prima: " + numero); 
        numero = numero * 2; 
        Console.WriteLine("Dopo: " + numero); 
    }

        // =====================================
        // 2) Esercizio aggiustaData 
        // =====================================

    static void AggiustaData(ref int giorno, ref int mese, ref int anno) 
    { 
        if (giorno > 30) 
        { 
            giorno -= 30; 
            mese++; 
        } 
        if (mese > 12) 
        { mese -= 12; 
        anno++; 
        } 
    }

        // =====================================
        // 3) Esercizio dividi 
        // =====================================

    static void Dividi(int a, int b, out int quoziente, out int resto) 
    { 
        quoziente = a / b; 
        resto = a % b; 
    }

        // =====================================
        // 4) Esercizio analizzaParole 
        // ===================================== 

    static void AnalizzaParola(string testo, out int vocali, out int consonanti, out int spazi) 
    { 
        vocali = 0; 
        consonanti = 0; 
        spazi = 0; 

        foreach (char c in testo.ToLower()) 
        { 
            if ("aeiou".Contains(c)) 
                vocali++; 
            else if (c == ' ') 
                spazi++; 
            else if (char.IsLetter(c)) 
                consonanti++; 
        } 
    }

        // =====================================
        // 5) Esercizio aggiornaPunteggio  
        // ===================================== 

    static void AggiornaPunteggio(ref int punteggioCorrente, int bonus, ref int punteggioTotale, out float media)
    {
    // Aggiorna il punteggio corrente
    punteggioCorrente += bonus;

    // Aggiorna il totale
    punteggioTotale += punteggioCorrente;

    // La media verrà calcolata solo dopo 3 turni
    media = punteggioTotale / 3f;
    }

        // =====================================
        // 6) Esercizio raddoppia 
        // ===================================== 

    static bool ElaboraStudente(ref int voto1, ref int voto2, int bonus, out double media)
    {
    // Applica il bonus senza superare 10
    voto1 = Math.Min(voto1 + bonus, 10);
    voto2 = Math.Min(voto2 + bonus, 10);

    // Calcola la media
    media = (voto1 + voto2) / 2.0;

    // Ritorna true se promosso
    return media >= 6;
    }

}