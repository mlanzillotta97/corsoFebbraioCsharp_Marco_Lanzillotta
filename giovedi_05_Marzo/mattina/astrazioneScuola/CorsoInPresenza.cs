using System;

public class CorsoInPresenza : Corso
{
    private string aula;
    private int numeroPosti;

    public string Aula
    {
        get { return aula; }
        set { aula = value; }
    }

    public int NumeroPosti
    {
        get { return numeroPosti; }
        set
        {
            if (value >= 1)
                numeroPosti = value;
            else
                numeroPosti = 1;
        }
    }

    public CorsoInPresenza(string titolo, int durataOre, Docente docente, string aula, int numeroPosti)
        : base(titolo, durataOre, docente)
    {
        Aula = aula;
        NumeroPosti = numeroPosti;
    }

    public override void ErogaCorso()
    {
        Console.WriteLine("Il corso si svolge in presenza nell'aula " + Aula);
    }

    public override void StampaDettagli()
    {
        Console.WriteLine("Corso in presenza: " + Titolo);
        Console.WriteLine("Durata: " + DurataOre + " ore");
        Console.WriteLine("Aula: " + Aula);
        Console.WriteLine("Posti disponibili: " + NumeroPosti);
        DocenteCorso.StampaDocente();
    }
}