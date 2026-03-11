// Classe concreta di piatto base

public class Pizza : IPiatto
{
    public string Descrizione()
    {
        return "Pizza";
    }

    public string Prepara()
    {
        return "Preparazione base della pizza";
    }
}