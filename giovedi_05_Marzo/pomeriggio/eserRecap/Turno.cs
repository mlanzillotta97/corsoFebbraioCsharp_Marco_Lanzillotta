using System;

public class Turno
{
    public string OraInizio { get; set; }
    public string OraFine { get; set; }

    public Turno(string inizio, string fine)
    {
        OraInizio = inizio;
        OraFine = fine;
    }

    public void MostraTurno()
    {
        Console.WriteLine("Turno: " + OraInizio + " - " + OraFine);
    }
}