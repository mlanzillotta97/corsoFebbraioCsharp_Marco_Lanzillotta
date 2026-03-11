public abstract class DecoratoreTorta : ITorta
{
    protected ITorta baseTorta;

    public DecoratoreTorta(ITorta torta)
    {
        baseTorta = torta;
    }

    public virtual string Descrizione()
    {
        return baseTorta.Descrizione();
    }
}