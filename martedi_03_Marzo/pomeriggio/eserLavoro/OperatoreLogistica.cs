using System;

namespace GestioneOperatori
{
    public class OperatoreLogistica : Operatore
    {
        private int numeroConsegne;

        public int NumeroConsegne
        {
            get { return numeroConsegne; }
            set
            {
                if (value >= 0)
                    numeroConsegne = value;
                else
                    Console.WriteLine("Il numero di consegne non può essere negativo.");
            }
        }

        public override void EseguiCompito()
        {
            Console.WriteLine("Coordinamento di " + NumeroConsegne + " consegne");
        }
    }
}