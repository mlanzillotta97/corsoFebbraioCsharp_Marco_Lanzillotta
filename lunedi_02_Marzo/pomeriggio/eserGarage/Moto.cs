using System;

public class Moto : Veicolo
{
    public string TipoManubrio { get; set; }

    public Moto(string marca, string modello, string tipoManubrio)
        : base(marca, modello)
    {
        TipoManubrio = tipoManubrio;
    }

    public override void StampaInfo()
    {
        Console.WriteLine($"Moto - Marca: {Marca}, Modello: {Modello}, Manubrio: {TipoManubrio}");
    }
}