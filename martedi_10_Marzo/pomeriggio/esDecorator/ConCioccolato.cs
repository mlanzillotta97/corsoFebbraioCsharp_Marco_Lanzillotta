namespace BarDecorator
{
    class ConCioccolato : DecoratoreBevanda
    {
        public ConCioccolato(IBevanda b) : base(b) { }

        public override string Descrizione()
        {
            return bevanda.Descrizione() + " + Cioccolato";
        }

        public override double Costo()
        {
            return bevanda.Costo() + 0.70;
        }
    }
}