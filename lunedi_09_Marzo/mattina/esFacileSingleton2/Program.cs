using System;

class Program
{
    static void Main(string[] args)
    {
        ModuloA a = new ModuloA();
        ModuloB b = new ModuloB();

        a.Esegui();
        b.Esegui();

        Console.WriteLine("\nTutte le configurazioni:");

        ConfigurazioneSistema.Instance.StampaTutte();
    }
}