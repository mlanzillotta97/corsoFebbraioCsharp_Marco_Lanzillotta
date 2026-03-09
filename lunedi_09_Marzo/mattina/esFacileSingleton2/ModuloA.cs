using System;

public class ModuloA
{
    public void Esegui()
    {
        var config = ConfigurazioneSistema.Instance;

        config.Imposta("Tema", "Scuro");
        config.Imposta("Lingua", "Italiano");

        Console.WriteLine("ModuloA legge Tema: " + config.Leggi("Tema"));
    }
}