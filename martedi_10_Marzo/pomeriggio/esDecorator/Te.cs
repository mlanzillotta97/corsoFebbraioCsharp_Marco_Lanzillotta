namespace BarDecorator
{
    class Te : IBevanda
    {
        public string Descrizione()
        {
            return "Tè";
        }

        public double Costo()
        {
            return 1.00;
        }
    }
}