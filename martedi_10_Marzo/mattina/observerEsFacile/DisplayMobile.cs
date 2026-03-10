using System;

namespace ObserverMeteo
{
    class DisplayMobile : IObserver
    {
        public void Aggiorna(string messaggio)
        {
            Console.WriteLine("Display Mobile: Notifica meteo -> " + messaggio);
        }
    }
}