using System;

class Gallina : Animale
{
    public int UovaProdotte { get; set; }

    public Gallina(string nome, int eta, int uova) : base(nome, eta)
    {
        UovaProdotte = uova;
    }

    public override void MostraInfo()
    {
        base.MostraInfo();
        Console.WriteLine($"Uova prodotte: {UovaProdotte}");
    }

    public override void Verso()
    {
        Console.WriteLine("Coccodè!");
    }
}