using System;

class Pecora : Animale
{
    public string TipoLana { get; set; }

    public Pecora(string nome, int eta, string tipoLana) : base(nome, eta)
    {
        TipoLana = tipoLana;
    }

    public override void MostraInfo()
    {
        base.MostraInfo();
        Console.WriteLine($"Tipo di lana: {TipoLana}");
    }

    public override void Verso()
    {
        Console.WriteLine("Beeh!");
    }
}