public class ConGlassa : DecoratoreTorta
{
    public ConGlassa(ITorta torta) : base(torta) { }

    public override string Descrizione()
    {
        return base.Descrizione() + " + glassa";
    }
}