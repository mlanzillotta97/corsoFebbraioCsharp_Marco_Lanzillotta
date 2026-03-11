using System;

public class Calcolatrice
{
    private IStrategiaOperazione strategia;

    public void ImpostaStrategia(IStrategiaOperazione nuovaStrategia)
    {
        strategia = nuovaStrategia;
    }

    public double EseguiOperazione(double a, double b)
    {
        if (strategia == null)
            throw new InvalidOperationException("Strategia non impostata!");
        return strategia.Calcola(a, b);
    }
}