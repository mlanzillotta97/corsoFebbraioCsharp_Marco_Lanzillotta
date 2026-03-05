using System;

public class Docente
{
    private string nome;
    private string materia;

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public string Materia
    {
        get { return materia; }
        set { materia = value; }
    }

    public Docente(string nome, string materia)
    {
        Nome = nome;
        Materia = materia;
    }

    public void StampaDocente()
    {
        Console.WriteLine("Docente: " + Nome + " - Materia: " + Materia);
    }
}