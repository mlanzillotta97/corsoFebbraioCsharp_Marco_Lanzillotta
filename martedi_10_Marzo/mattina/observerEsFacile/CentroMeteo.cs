using System;
using System.Collections.Generic;

namespace ObserverMeteo
{
    class CentroMeteo : ISoggetto
    {
        private List<IObserver> osservatori = new List<IObserver>();

        public void Registra(IObserver osservatore)
        {
            osservatori.Add(osservatore);
        }

        public void Rimuovi(IObserver osservatore)
        {
            osservatori.Remove(osservatore);
        }

        public void Notifica(string messaggio)
        {
            foreach (var osservatore in osservatori)
            {
                osservatore.Aggiorna(messaggio);
            }
        }

        public void AggiornaMeteo(string dati)
        {
            Console.WriteLine("\nCentro Meteo: nuovi dati meteo -> " + dati);
            Notifica(dati);
        }
    }
}