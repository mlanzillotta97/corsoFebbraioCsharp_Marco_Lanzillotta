using System;

public class Macchina
{
    public string Motore;
    public float VelocitaMac;
    public int SospensioniMax;
    public int NrModifiche;

    public Macchina(string motore)
    {
        Motore = motore;
        VelocitaMac = 100;
        SospensioniMax = 5;
        NrModifiche = 0;
    }

    public void AumentaVelocita()
    {
        VelocitaMac += 10;
        NrModifiche++;
    }

    public void CambiaMotore(string nuovoMotore)
    {
        Motore = nuovoMotore;
        NrModifiche++;
    }

    public void AumentaSospensioni()
    {
        SospensioniMax += 1;
        NrModifiche++;
    }

    public void StampaDettagli()
    {
        Console.WriteLine("\n--- CARATTERISTICHE FINALI ---");
        Console.WriteLine("Motore: " + Motore);
        Console.WriteLine("Velocità: " + VelocitaMac);
        Console.WriteLine("Sospensioni: " + SospensioniMax);
        Console.WriteLine("Numero modifiche: " + NrModifiche);
    }
}