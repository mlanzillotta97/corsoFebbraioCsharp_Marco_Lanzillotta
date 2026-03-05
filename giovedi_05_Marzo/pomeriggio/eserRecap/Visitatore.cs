using System; 

//EREDITARIETÀ 
public class Visitatore : Persona
{
    private string azienda;

    public string Azienda
    {
        get { return azienda; }
        set { azienda = value; }
    }

    public Visitatore(int id, string nome, string azienda)
        : base(id, nome)
    {
        Azienda = azienda;
    }

    public override void MostraRuolo()
    {
        Console.WriteLine("Visitatore da: " + Azienda);
    }
}