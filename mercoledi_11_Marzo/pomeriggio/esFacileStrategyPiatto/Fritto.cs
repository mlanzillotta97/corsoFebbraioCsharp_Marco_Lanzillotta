// Strategia concreta: fritto

public class Fritto : IPreparazioneStrategia
{
    public string Prepara(string descrizione)
    {
        return descrizione + " fritto";
    }
}