// Strategia concreta: alla griglia

public class AllaGriglia : IPreparazioneStrategia
{
    public string Prepara(string descrizione)
    {
        return descrizione + " alla griglia";
    }
}