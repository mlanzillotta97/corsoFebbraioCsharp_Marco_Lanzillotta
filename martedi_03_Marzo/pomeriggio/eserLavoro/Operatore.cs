using System;

namespace GestioneOperatori
{
    public class Operatore
    {
        private string nome;
        private string turno;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Turno
        {
            get { return turno; }
            set
            {
                if (value.ToLower() == "giorno" || value.ToLower() == "notte")
                    turno = value;
                else
                    Console.WriteLine("Turno non valido! Inserire 'giorno' o 'notte'.");
            }
        }

        public virtual void EseguiCompito()
        {
            Console.WriteLine("Operatore generico in servizio.");
        }
    }
}