using System;

public class Animale
{
    public void FaiVerso()
    {
        Console.WriteLine("L'animale fa un verso.");
    }
    public virtual void Verso()
    {
        Console.WriteLine("L'animale emette un verso.");
    }
}