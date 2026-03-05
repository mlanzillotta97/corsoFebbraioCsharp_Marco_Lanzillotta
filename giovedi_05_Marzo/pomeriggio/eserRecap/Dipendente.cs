using System; 

//EREDITARIETÀ
public class Dipendente : Persona
{
    private string reparto;

    public string Reparto
    {
        get { return reparto; }
        set { reparto = value; }
    }

    public Dipendente(int id, string nome, string reparto)
        : base(id, nome)
    {
        Reparto = reparto;
    }

    public override void MostraRuolo()
    {
        Console.WriteLine("Dipendente del reparto: " + Reparto);
    }
}