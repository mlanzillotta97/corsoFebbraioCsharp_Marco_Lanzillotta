// ===== DECORATOR CONCRETO =====
// Aggiunge formaggio al piatto

public class ConFormaggio : IngredienteExtra
{
    public ConFormaggio(IPiatto p) : base(p) { }

    public override string Descrizione()
    {
        return base.Descrizione() + " + formaggio";
    }
}