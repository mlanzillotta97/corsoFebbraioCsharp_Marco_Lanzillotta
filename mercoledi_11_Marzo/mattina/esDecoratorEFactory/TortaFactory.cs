public static class TortaFactory
{
    public static ITorta CreaTortaBase(string tipo)
    {
        switch (tipo.ToLower())
        {
            case "cioccolato":
                return new TortaCioccolato();

            case "vaniglia":
                return new TortaVaniglia();

            case "frutta":
                return new TortaFrutta();

            default:
                throw new ArgumentException("Tipo di torta non valido");
        }
    }
}