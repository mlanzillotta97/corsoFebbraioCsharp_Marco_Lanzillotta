using System;

namespace ObserverUtenti
{
    class ModuloLog : IObserver
    {
        public void NotificaCreazione(string nomeUtente)
        {
            Console.WriteLine("[LOG] Creato nuovo utente: " + nomeUtente);
        }
    }
}