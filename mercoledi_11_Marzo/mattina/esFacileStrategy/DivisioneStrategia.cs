using System;

public class DivisioneStrategia : IStrategiaOperazione
{
    public double Calcola(double a, double b)
    {
        if (b == 0)
            throw new DivideByZeroException("Non si può dividere per zero!");
        return a / b;
    }
}