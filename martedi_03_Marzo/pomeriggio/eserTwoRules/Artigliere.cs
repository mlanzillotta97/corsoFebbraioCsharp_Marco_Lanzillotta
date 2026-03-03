using System;

namespace Esercito
{
    public class Artigliere : Soldato
    {
        private int calibro;

        public int Calibro
        {
            get { return calibro; }
            set
            {
                if (value > 0)
                    calibro = value;
                else
                    Console.WriteLine("Il calibro deve essere positivo.");
            }
        }

        public Artigliere(string nome, string grado, int anniServizio, int calibro)
            : base(nome, grado, anniServizio)
        {
            Calibro = calibro;
        }

        public override void Descrizione()
        {
            Console.WriteLine("ARTIGLIERE -> Nome: " + Nome +
                            " | Grado: " + Grado +
                            " | Anni di servizio: " + AnniServizio +
                            " | Calibro: " + Calibro);
        }
    }
}