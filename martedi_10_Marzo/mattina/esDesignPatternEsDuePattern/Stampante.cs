using System;

namespace SistemaConfigurazione
{
    class Stampante : IDispositivo
    {
        public void Avvia()
        {
            Console.WriteLine("La stampante si accende");
        }

        public void MostraTipo()
        {
            Console.WriteLine("Tipo: Stampante");
        }
    }
}