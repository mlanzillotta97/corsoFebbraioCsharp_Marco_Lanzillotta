using System;

namespace OfficinaMeccanica
{
    public class Auto : Veicolo
    {
        public Auto(string targa) : base(targa) { }

        public override void Ripara()
        {
            Console.WriteLine("Controllo olio, freni e motore dell'auto.");
        }
    }
}