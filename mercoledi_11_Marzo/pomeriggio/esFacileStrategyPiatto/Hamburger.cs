// Classe concreta di piatto base

public class Hamburger : IPiatto
{
    public string Descrizione()
    {
        return "Hamburger";
    }

    public string Prepara()
    {
        return "Preparazione base dell'hamburger";
    }
}