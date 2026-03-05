using System;

public class CorsoOnline : Corso
{
    private string piattaforma;
    private string linkAccesso;

    public string Piattaforma
    {
        get { return piattaforma; }
        set { piattaforma = value; }
    }

    public string LinkAccesso
    {
        get { return linkAccesso; }
        set { linkAccesso = value; }
    }

    public CorsoOnline(string titolo, int durataOre, Docente docente, string piattaforma, string link)
        : base(titolo, durataOre, docente)
    {
        Piattaforma = piattaforma;
        LinkAccesso = link;
    }

    public override void ErogaCorso()
    {
        Console.WriteLine("Il corso viene erogato online tramite " + Piattaforma);
    }

    public override void StampaDettagli()
    {
        Console.WriteLine("Corso online: " + Titolo);
        Console.WriteLine("Durata: " + DurataOre + " ore");
        Console.WriteLine("Piattaforma: " + Piattaforma);
        Console.WriteLine("Link: " + LinkAccesso);
        DocenteCorso.StampaDocente();
    }
}