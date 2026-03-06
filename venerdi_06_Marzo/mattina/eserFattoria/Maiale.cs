using System;

class Maiale : Animale
{
    public double Peso { get; set; }

    public Maiale(string nome, int eta, double peso) : base(nome, eta)
    {
        Peso = peso;
    }

    public override void MostraInfo()
    {
        base.MostraInfo();
        Console.WriteLine($"Peso (kg): {Peso}");
    }

    public override void Verso()
    {
        Console.WriteLine("Oink! Oink!");
    }
}