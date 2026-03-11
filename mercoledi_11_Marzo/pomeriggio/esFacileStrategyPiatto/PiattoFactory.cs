using System;

// ===== FACTORY PATTERN =====
// Classe Factory che crea i piatti base

public static class PiattoFactory
{
    public static IPiatto Crea(string tipo)
    {
        switch (tipo.ToLower())
        {
            case "pizza":
                return new Pizza();

            case "hamburger":
                return new Hamburger();

            case "insalata":
                return new Insalata();

            default:
                throw new ArgumentException("Tipo di piatto non valido");
        }
    }
}