using System; 

//INCAPSULAMENTO 

public class Badge
{
    private int codice;
    private bool attivo;

    public int Codice
    {
        get { return codice; }
        set { codice = value; }
    }

    public bool Attivo
    {
        get { return attivo; }
        set { attivo = value; }
    }

    public Badge(int codice)
    {
        Codice = codice;
        Attivo = true;
    }

    public void MostraBadge()
    {
        Console.WriteLine("Badge: " + Codice + " Attivo: " + Attivo);
    }
}