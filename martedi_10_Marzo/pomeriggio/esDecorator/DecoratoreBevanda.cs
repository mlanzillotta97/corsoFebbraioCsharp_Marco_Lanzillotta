namespace BarDecorator
{
    abstract class DecoratoreBevanda : IBevanda
    {
        protected IBevanda bevanda;

        public DecoratoreBevanda(IBevanda b)
        {
            bevanda = b;
        }

        public virtual string Descrizione()
        {
            return bevanda.Descrizione();
        }

        public virtual double Costo()
        {
            return bevanda.Costo();
        }
    }
}