using System;

public class AccessoLog
{
    public void RegistraEntrata(Persona persona)
    {
        Console.WriteLine(persona.Nome + " è entrato alle " + DateTime.Now);
    }

    public void RegistraUscita(Persona persona)
    {
        Console.WriteLine(persona.Nome + " è uscito alle " + DateTime.Now);
    }
}