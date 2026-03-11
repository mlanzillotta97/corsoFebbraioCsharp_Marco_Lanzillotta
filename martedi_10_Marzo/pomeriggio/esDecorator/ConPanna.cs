namespace BarDecorator
{
    class ConPanna : DecoratoreBevanda
    {
        public ConPanna(IBevanda b) : base(b) { }

        public override string Descrizione()
        {
            return bevanda.Descrizione() + " + Panna";
        }

        public override double Costo()
        {
            return bevanda.Costo() + 0.60;
        }
    }
}