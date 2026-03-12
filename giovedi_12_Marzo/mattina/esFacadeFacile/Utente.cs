using System;

public class Utente : IObserver
{
    private string nome;

    public Utente(string nome)
    {
        this.nome = nome;
    }

    public void Update(string messaggio)
    {
        Console.WriteLine(nome + " riceve notifica: " + messaggio);
    }
}