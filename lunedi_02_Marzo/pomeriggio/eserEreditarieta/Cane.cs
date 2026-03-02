using System;

public class Cane : Animale
{
    public void Scodinzola()
    {
        Console.WriteLine("Il cane scodinzola.");
    }

    public override void Verso()
    {
        Console.WriteLine("Il cane abbaia.");
    }
}