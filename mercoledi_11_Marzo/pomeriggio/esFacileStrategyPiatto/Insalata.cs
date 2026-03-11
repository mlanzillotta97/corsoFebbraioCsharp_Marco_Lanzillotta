// Classe concreta di piatto base

public class Insalata : IPiatto
{
    public string Descrizione()
    {
        return "Insalata";
    }

    public string Prepara()
    {
        return "Preparazione base dell'insalata";
    }
}