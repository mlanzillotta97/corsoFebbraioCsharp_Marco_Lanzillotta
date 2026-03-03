using System;

namespace AgenziaViaggi
{
    class Program
    {
        static void Main(string[] args)
        {
            PrenotazioneViaggio prenotazione = 
                new PrenotazioneViaggio("Roma");

            Console.WriteLine("Destinazione: " + prenotazione.Destinazione);
            MostraStato(prenotazione);

            // Prenotazioni
            prenotazione.PrenotaPosti(5);
            MostraStato(prenotazione);

            prenotazione.PrenotaPosti(8);
            MostraStato(prenotazione);

            // Tentativo non valido
            prenotazione.PrenotaPosti(10);
            MostraStato(prenotazione);

            // Annullamenti
            prenotazione.AnnullaPrenotazione(3);
            MostraStato(prenotazione);

            // Tentativo non valido
            prenotazione.AnnullaPrenotazione(20);
            MostraStato(prenotazione);
        }

        static void MostraStato(PrenotazioneViaggio p)
        {
            Console.WriteLine("Posti prenotati: " + p.PostiPrenotati);
            Console.WriteLine("Posti disponibili: " + p.PostiDisponibili);
            Console.WriteLine("-----------------------------");
        }
    }
}