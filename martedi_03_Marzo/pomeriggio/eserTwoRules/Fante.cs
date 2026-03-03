using System;

namespace Esercito
{
    public class Fante : Soldato
    {
        private string arma;

        public string Arma
        {
            get { return arma; }
            set { arma = value; }
        }

        public Fante(string nome, string grado, int anniServizio, string arma)
            : base(nome, grado, anniServizio)
        {
            Arma = arma;
        }

        public override void Descrizione()
        {
            Console.WriteLine("FANTE -> Nome: " + Nome +
                            " | Grado: " + Grado +
                            " | Anni di servizio: " + AnniServizio +
                            " | Arma: " + Arma);
        }
    }
}