// ===== STRATEGY CONTEXT =====
// La classe Chef utilizza una strategia di preparazione

public class Chef
{
    private IPreparazioneStrategia strategia;

    public void SetStrategia(IPreparazioneStrategia s)
    {
        strategia = s;
    }

    public string PreparaPiatto(IPiatto piatto)
    {
        if (strategia == null)
            return "Strategia non impostata.";

        return strategia.Prepara(piatto.Descrizione());
    }
}