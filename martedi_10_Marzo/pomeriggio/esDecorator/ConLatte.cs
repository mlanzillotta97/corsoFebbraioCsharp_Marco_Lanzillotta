namespace BarDecorator
{
    class ConLatte : DecoratoreBevanda
    {
        public ConLatte(IBevanda b) : base(b) { }

        public override string Descrizione()
        {
            return bevanda.Descrizione() + " + Latte";
        }

        public override double Costo()
        {
            return bevanda.Costo() + 0.50;
        }
    }
}