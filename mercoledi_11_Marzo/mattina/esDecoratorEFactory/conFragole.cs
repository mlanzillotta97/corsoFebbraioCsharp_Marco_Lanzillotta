public class ConFragole : DecoratoreTorta
{
    public ConFragole(ITorta torta) : base(torta) { }

    public override string Descrizione()
    {
        return base.Descrizione() + " + fragole";
    }
}