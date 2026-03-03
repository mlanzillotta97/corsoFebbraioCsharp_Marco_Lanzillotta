using System;

namespace OfficinaMeccanica
{
    public class Veicolo
    {
        public string Targa;

        public Veicolo(string targa)
        {
            Targa = targa;
        }

        public virtual void Ripara()
        {
            Console.WriteLine("Il veicolo viene controllato.");
        }
    }
}