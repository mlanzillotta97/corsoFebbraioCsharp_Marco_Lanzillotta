// ===== DECORATOR PATTERN =====
// Classe decoratore astratta
// Permette di aggiungere ingredienti dinamicamente

public abstract class IngredienteExtra : IPiatto
{
    protected IPiatto piatto;

    public IngredienteExtra(IPiatto p)
    {
        piatto = p;
    }

    public virtual string Descrizione()
    {
        return piatto.Descrizione();
    }

    public virtual string Prepara()
    {
        return piatto.Prepara();
    }
}