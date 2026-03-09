using System;

public class ModuloB
{
    public void Esegui()
    {
        var config = ConfigurazioneSistema.Instance;

        config.Imposta("Volume", "80");

        Console.WriteLine("ModuloB legge Lingua: " + config.Leggi("Lingua"));
    }
}