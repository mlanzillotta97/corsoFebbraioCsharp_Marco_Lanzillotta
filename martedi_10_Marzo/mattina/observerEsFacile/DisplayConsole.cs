using System;

namespace ObserverMeteo
{
    class DisplayConsole : IObserver
    {
        public void Aggiorna(string messaggio)
        {
            Console.WriteLine("Display Console: Meteo aggiornato -> " + messaggio);
        }
    }
}