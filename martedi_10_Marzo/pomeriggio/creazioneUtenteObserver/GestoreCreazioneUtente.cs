using System;
using System.Collections.Generic;

namespace ObserverUtenti
{
    class GestoreCreazioneUtente : ISoggetto
    {
        private List<IObserver> osservatori = new List<IObserver>();

        public void Registra(IObserver o)
        {
            osservatori.Add(o);
        }

        public void Rimuovi(IObserver o)
        {
            osservatori.Remove(o);
        }

        public void Notifica(string nomeUtente)
        {
            foreach (var o in osservatori)
            {
                o.NotificaCreazione(nomeUtente);
            }
        }

        public void CreaUtente(string nome)
        {
            Utente u = UserFactory.Crea(nome);

            Console.WriteLine(u.ToString());

            Notifica(nome);
        }
    }
}