// ===== DECORATOR CONCRETO =====
// Aggiunge bacon al piatto

public class ConBacon : IngredienteExtra
{
    public ConBacon(IPiatto p) : base(p) { }

    public override string Descrizione()
    {
        return base.Descrizione() + " + bacon";
    }
}