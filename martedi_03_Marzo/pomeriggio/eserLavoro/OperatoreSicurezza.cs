using System;

namespace GestioneOperatori
{
    public class OperatoreSicurezza : Operatore
    {
        public string AreaSorvegliata { get; set; }

        public override void EseguiCompito()
        {
            Console.WriteLine("Sorveglianza dell'area " + AreaSorvegliata);
        }
    }
}