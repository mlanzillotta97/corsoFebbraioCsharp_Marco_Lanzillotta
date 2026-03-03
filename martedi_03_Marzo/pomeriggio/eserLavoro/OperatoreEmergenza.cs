using System;

namespace GestioneOperatori
{
    public class OperatoreEmergenza : Operatore
    {
        private int livelloUrgenza;

        public int LivelloUrgenza
        {
            get { return livelloUrgenza; }
            set
            {
                if (value >= 1 && value <= 5)
                    livelloUrgenza = value;
                else
                    Console.WriteLine("Il livello urgenza deve essere tra 1 e 5.");
            }
        }

        public override void EseguiCompito()
        {
            Console.WriteLine("Gestione emergenza di livello " + LivelloUrgenza);
        }
    }
}