using System;

namespace ScuolaArtistica
{
    public class CorsoDanza : Corso
    {
        public string Stile;

        public CorsoDanza(string nome, int durata, string docente, string stile)
            : base(nome, durata, docente)
        {
            Stile = stile;
        }

        public override void MetodoSpeciale()
        {
            Console.WriteLine("Esecuzione coreografia nello stile: " + Stile);
        }

        public override string ToString()
        {
            return base.ToString() + " | Stile: " + Stile;
        }
    }
}