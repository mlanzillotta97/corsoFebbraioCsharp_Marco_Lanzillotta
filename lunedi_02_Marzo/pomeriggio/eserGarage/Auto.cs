using System;

public class Auto : Veicolo
{
    public int NumeroPorte { get; set; }

    public Auto(string marca, string modello, int numeroPorte)
        : base(marca, modello)
    {
        NumeroPorte = numeroPorte;
    }

    public override void StampaInfo()
    {
        Console.WriteLine($"Auto - Marca: {Marca}, Modello: {Modello}, Porte: {NumeroPorte}");
    }
}