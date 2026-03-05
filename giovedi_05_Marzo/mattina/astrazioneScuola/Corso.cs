using System;

public abstract class Corso
{
    private string titolo;
    private int durataOre;
    private Docente docente;

    public string Titolo
    {
        get { return titolo; }
        set { titolo = value; }
    }

    public int DurataOre
    {
        get { return durataOre; }
        set
        {
            if (value >= 0)
                durataOre = value;
            else
                durataOre = 0;
        }
    }

    public Docente DocenteCorso
    {
        get { return docente; }
        set { docente = value; }
    }

    public Corso(string titolo, int durataOre, Docente docente)
    {
        Titolo = titolo;
        DurataOre = durataOre;
        DocenteCorso = docente;
    }

    public abstract void ErogaCorso();
    public abstract void StampaDettagli();
}