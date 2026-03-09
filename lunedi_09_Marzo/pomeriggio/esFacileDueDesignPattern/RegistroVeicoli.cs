using System;
using System.Collections.Generic;

public class RegistroVeicoli
{
    private static RegistroVeicoli istanza;

    private List<IVeicolo> veicoliCreati = new List<IVeicolo>();

    private RegistroVeicoli()
    {
    }

    public static RegistroVeicoli Instance
    {
        get
        {
            if (istanza == null)
            {
                istanza = new RegistroVeicoli();
            }

            return istanza;
        }
    }

    public void Registra(IVeicolo veicolo)
    {
        veicoliCreati.Add(veicolo);
    }

    public void StampaTutti()
    {
        Console.WriteLine("\nVeicoli registrati:");

        foreach (var v in veicoliCreati)
        {
            v.MostraTipo();
        }
    }
}