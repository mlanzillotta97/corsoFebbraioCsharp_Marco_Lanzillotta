using System;

class Mucca : Animale
{
    public double LatteProdottoLitri { get; set; }

    public Mucca(string nome, int eta, double latte) : base(nome, eta)
    {
        LatteProdottoLitri = latte;
    }

    public override void MostraInfo()
    {
        base.MostraInfo();
        Console.WriteLine($"Latte prodotto (litri): {LatteProdottoLitri}");
    }

    public override void Verso()
    {
        Console.WriteLine("Mu! Mu!");
    }
}