using System;

namespace ObserverUtenti
{
    class ModuloMarketing : IObserver
    {
        public void NotificaCreazione(string nomeUtente)
        {
            Console.WriteLine("[MARKETING] Invia email di benvenuto a: " + nomeUtente);
        }
    }
}