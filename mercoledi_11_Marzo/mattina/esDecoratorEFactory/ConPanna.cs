public class ConPanna : DecoratoreTorta
{
    public ConPanna(ITorta torta) : base(torta) { }

    public override string Descrizione()
    {
        return base.Descrizione() + " + panna";
    }
}