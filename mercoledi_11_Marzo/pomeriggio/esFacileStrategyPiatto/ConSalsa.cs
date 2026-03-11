// ===== DECORATOR CONCRETO =====
// Aggiunge salsa al piatto

public class ConSalsa : IngredienteExtra
{
    public ConSalsa(IPiatto p) : base(p) { }

    public override string Descrizione()
    {
        return base.Descrizione() + " + salsa";
    }
}