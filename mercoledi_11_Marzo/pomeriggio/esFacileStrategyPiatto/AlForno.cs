// Strategia concreta: al forno

public class AlForno : IPreparazioneStrategia
{
    public string Prepara(string descrizione)
    {
        return descrizione + " al forno";
    }
}