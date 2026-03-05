using System; 

//ASTRAZIONE + INCAPSULAMENTO 
public abstract class Persona
{
    private int id;
    private string nome;

    public int Id
    {
        get { return id; }
        set
        {
            if (value > 0)
                id = value;
        }
    }

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public Persona(int id, string nome)
    {
        Id = id;
        Nome = nome;
    }

    public abstract void MostraRuolo();
}