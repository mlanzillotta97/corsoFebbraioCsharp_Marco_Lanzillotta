using System;

public static class VeicoloFactory
{
    public static IVeicolo CreaVeicolo(string tipo)
    {
        if (tipo.ToLower() == "auto")
            return new Auto();

        if (tipo.ToLower() == "moto")
            return new Moto();

        if (tipo.ToLower() == "camion")
            return new Camion();

        Console.WriteLine("Tipo di veicolo non valido");
        return null;
    }
}