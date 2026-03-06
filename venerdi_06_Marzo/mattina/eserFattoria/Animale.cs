using System;

abstract class Animale
{
    private string nome;
    private int eta;

    public string Nome
    {
        get => nome;
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                nome = value;
            else
                Console.WriteLine("Nome non valido.");
        }
    }

    public int Eta
    {
        get => eta;
        set
        {
            if (value >= 0)
                eta = value;
            else
                Console.WriteLine("Età non valida.");
        }
    }

    protected Animale(string nome, int eta)
    {
        Nome = nome;
        Eta = eta;
    }

    public virtual void MostraInfo()
    {
        Console.WriteLine($"Tipo: {this.GetType().Name}, Nome: {Nome}, Età: {Eta}");
    }

    public abstract void Verso();
}